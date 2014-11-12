using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.HttpContext
{
    public class HttpContextStrategyProvider : IHttpContextStrategyProvider
    {
        private static IHttpContextAdapter _currentContext;
        private readonly Dictionary<ContextType, IHttpContextAdapter> _contextAdapters;

        public HttpContextStrategyProvider(IEnumerable<IHttpContextAdapter> contextAdapters)
        {
            _contextAdapters = contextAdapters.ToDictionary(x => x.ContextType);
        }

        public IHttpContextAdapter CurrentContext
        {
            get
            {
                if (_currentContext == null)
                {
                    IdentifyContextToUse();
                }
                return _currentContext;
            }
        }

        public UserModel GetUser(bool checkSiteMinderOnly)
        {
            if (checkSiteMinderOnly) return _contextAdapters[ContextType.SiteMinder].GetUser();

            UserModel userModel = CurrentContext.GetUser();
            return userModel;
        }

        public UserModel ClearUser()
        {
            UserModel userModel = CurrentContext.ClearUser();
            return userModel;
        }

        public string GetUserName()
        {
            string username = CurrentContext.GetUserName();
            return username;
        }

        public string GetUserPwd()
        {
            string pwd = CurrentContext.GetUserPwd();
            return pwd;
        }

        public string GetUserToken()
        {
            string token = CurrentContext.GetToken();
            return token;
        }

        public void StoreToken(string token)
        {
            CurrentContext.StoreToken(token);
        }

        public void StoreAuthorizedUser(UserModel userModel)
        {
            CurrentContext.StoreAuthorizedUser(userModel);
        }

        public string GetHttpSessionId()
        {
            string sessionId = CurrentContext.GetHttpSessionId();
            return sessionId;
        }

        public string GetUserUniversalId()
        {
            string universalId = CurrentContext.GetUserUniversalId();
            return universalId;
        }

        public List<string> GetUserGroups()
        {
            List<string> groups = CurrentContext.GetUserGroups();
            return groups;
        }

        public void ApplyPermissions(PermissionModel permission)
        {
            CurrentContext.ApplyPermissions(permission);
        }

        public PermissionModel GetPermissions()
        {
            return CurrentContext.GetPermissions();
        }

        private void IdentifyContextToUse()
        {
            //siteminder
            if (!string.IsNullOrEmpty(_contextAdapters[ContextType.SiteMinder].GetUserName()))
                _currentContext = _contextAdapters[ContextType.SiteMinder];

                //local
            else if (!string.IsNullOrEmpty(_contextAdapters[ContextType.Local].GetHttpSessionId()))
            {
                _currentContext = _contextAdapters[ContextType.Local];
            }

            //test
        }
    }
}