using System;
using System.Reflection;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;
using log4net;

namespace com.gaic.insuredPortal.DomainServices
{
    public class AuthorizationService : IAuthorizationService
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IHttpContextStrategyProvider _contextStrategyProvider;
        private readonly ILdapProvider _ldapProvider;
        private readonly IPermissionProvider _permissionProvider;
        private readonly ISingleSignonProvider _signonProvider;

        public AuthorizationService(IHttpContextStrategyProvider contextStrategyProvider,
            ISingleSignonProvider signonProvider, ILdapProvider ldapProvider, IPermissionProvider permissionProvider)
        {
            _contextStrategyProvider = contextStrategyProvider;
            _signonProvider = signonProvider;
            _ldapProvider = ldapProvider;
            _permissionProvider = permissionProvider;
        }

        public UserModel GetAuthorizedUser()
        {
            //return new User(){UserId = "taccount1"};

            UserModel authorizedUser = _contextStrategyProvider.GetUser(false);
            if (authorizedUser == null)
            {
                _log.DebugFormat("_contextStrategyProvider.GetUser(false) returned null");
                return null;
            }
            if (HasStoredPermissions(authorizedUser) /*&& HasStoredIPAddress(authorizedUser)*/)
            {
                return authorizedUser;
            }

            //_log.DebugFormat("Apply permissions and ip address");
            ApplyPermissions(authorizedUser);
            //ApplyClientIpAddress(authorizedUser);
            return authorizedUser;
        }

        public void StoreAuthorizedUser(UserModel userModel)
        {
            _contextStrategyProvider.StoreAuthorizedUser(userModel);
            //Save in DB
            //_userProvider.SaveUser(user);
        }

        //public bool AuthorizeUser(bool siteMinderOnly)
        //{
        //    var user = GetAuthorizedUser();
        //    return user != null;
        //}

        public UserModel AuthorizeUser(bool checkSiteMinderOnly)
        {
            //siteminder user attempted first, then cached local user is retrieved
            UserModel user = _contextStrategyProvider.GetUser(checkSiteMinderOnly);
            if (checkSiteMinderOnly && user != null)
            {
                //ApplyPermissions(authorizedUser);
                return user;
            }

            //this is a case where a user is logged in and the server session is still active, 
            //but the user opens a new tab or browser and logs in as another user OR the user
            //closes all browsers but comes back in a few minutes later while teh session on
            //the server is still active and logs in as another user. 
            if (user != null && user.UserId != _contextStrategyProvider.GetUserName())
            {
                user = _contextStrategyProvider.ClearUser();
            }

            //if we are here, that means siteminder is not enabled and the local user 
            //isn't found probably just logging in or logging in as another user
            if (user != null) return user;

            string userId = _contextStrategyProvider.GetUserName();
            if (String.IsNullOrEmpty(userId)) return null; // can't do anything without a userid, can't help you

            //get a cached token or retrieve one if cached doesn't exist
            string token = GetToken(userId);

            // can't do anything without a token, can't help you either
            return String.IsNullOrEmpty(token) ? null : RetrieveStoreAuthorizedUser(userId, token);
        }

        private string GetToken(string userId)
        {
            string token = _contextStrategyProvider.GetUserToken();
            if (!String.IsNullOrEmpty(token)) return token;

            //we are here because a token was never generated for this user yet. Retrieve one now and store it
            string pwd = _contextStrategyProvider.GetUserPwd();

            token = GetSingleSignonToken(userId, pwd);

            //todo verify if we need to ensure token is valid and hasn't expired before storing it

            //store the generated token
            _contextStrategyProvider.StoreToken(token);
            return token;
        }

        private string GetSingleSignonToken(string userName, string pwd)
        {
            Ensure.ArgumentNotNullOrEmpty(userName, "UserName");
            Ensure.ArgumentNotNullOrEmpty(pwd, "Password");

            return _signonProvider.GetSingleSignonToken(userName, pwd);
        }

        private UserModel RetrieveStoreAuthorizedUser(string userId, string token)
        {
            //retrieve user details from ldap using token
            UserModel authorizedUserModel = GetUserFromLdap(userId, token);

            //if (authorizedUser != null)
            //{
            //    ApplyClientIpAddress(authorizedUser);
            //}

            //store authorized user
            StoreAuthorizedUser(authorizedUserModel);
            return authorizedUserModel;
        }

        public UserModel GetUserFromLdap(string userId, string token)
        {
            Ensure.ArgumentNotNullOrEmpty(userId, "UserId");
            Ensure.ArgumentNotNullOrEmpty(token, "Token");

            UserModel user = _ldapProvider.GetPerson(userId, token);
            if (user != null) user.Permission = _permissionProvider.GetUserPermissionSet(user.Roles);
            return user;
        }

        private void ApplyPermissions(UserModel authorizedUser)
        {
            if (authorizedUser == null) return;
            if (HasStoredPermissions(authorizedUser)) return;

            var groups = _contextStrategyProvider.GetUserGroups();
            var roles = RoleItemModel.MapToRoles(groups);
            authorizedUser.Roles = roles;
            authorizedUser.Permission = _permissionProvider.GetUserPermissionSet(roles);

            _contextStrategyProvider.ApplyPermissions(authorizedUser.Permission);
        }


        private bool HasStoredPermissions(UserModel authorizedUser)
        {
            if (authorizedUser.Permission == null) authorizedUser.Permission = _contextStrategyProvider.GetPermissions();
            return authorizedUser.Permission != null;
        }
    }
}