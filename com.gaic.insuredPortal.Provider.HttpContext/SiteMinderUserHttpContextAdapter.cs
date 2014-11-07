using System;
using System.Collections.Generic;
using System.Web;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.HttpContext
{
    public class SiteMinderUserHttpContextAdapter : IHttpContextAdapter
    {
        public ContextType ContextType
        {
            get { return ContextType.SiteMinder; }
        }

        public string GetUserName()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.Headers["SMUSER"]
                : null;
        }

        public string GetUserPwd()
        {
            throw new NotImplementedException();
        }

        public string GetUserUniversalId()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.Headers["SMUNIVERSALID"]
                : null;
        }

        public List<string> GetUserGroups()
        {
            string smGroups = System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.Headers["GROUPS"]
                : null;
            return UserModel.ParseLdapGroups(smGroups);
        }

        public string GetToken()
        {
            HttpCookie cookie = System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.Cookies["SMSESSION"]
                : null;
            string token = null;
            if (cookie != null)
            {
                token = cookie.Value;
            }
            return token;
        }

        public bool StoreToken(string token)
        {
            return false;
        }

        public void StoreAuthorizedUser(UserModel userModel)
        {
            //do nothing
        }

        public UserModel GetUser()
        {
            string userId = GetUserName();
            if (String.IsNullOrEmpty(userId)) return null;

            return new UserModel
            {
                UserId = userId,
                UniversalId = GetUserUniversalId(),
                Token = GetToken(),
                //IpAddress = GetUserIpAddress(),
            };
        }

        public UserModel ClearUser()
        {
            throw new NotImplementedException();
        }

        public string GetHttpSessionId()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session.SessionID
                : null;
        }

        public void ApplyPermissions(PermissionModel permission)
        {
            if (System.Web.HttpContext.Current != null)
            {
                System.Web.HttpContext.Current.Session["PERMISSIONSET"] = permission;
            }
        }

        public PermissionModel GetPermissions()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session["PERMISSIONSET"] as PermissionModel
                : null;
        }
    }
}