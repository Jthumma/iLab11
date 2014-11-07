using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.HttpContext
{
    public class LocalUserHttpContextAdapter : IHttpContextAdapter
    {
        public ContextType ContextType
        {
            get { return ContextType.Local; }
        }

        public string GetUserName()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.QueryString["USER"]
                  ?? System.Web.HttpContext.Current.Request.Form["USER"]
                : null;
        }

        public string GetUserPwd()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Request.QueryString["PASSWORD"]
                  ?? System.Web.HttpContext.Current.Request.Form["PASSWORD"]
                : null;
        }

        public string GetUserUniversalId()
        {
            UserModel userModel = GetUser();
            return userModel != null ? userModel.UniversalId : null;
        }

        public List<string> GetUserGroups()
        {
            return null;
        }

        public string GetToken()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session["TOKEN"] as string
                : null;
        }

        public bool StoreToken(string token)
        {
            if (System.Web.HttpContext.Current == null) return false;
            System.Web.HttpContext.Current.Session["TOKEN"] = token;
            return true;
        }

        public void StoreAuthorizedUser(UserModel userModel)
        {
            if (System.Web.HttpContext.Current != null)
            {
                System.Web.HttpContext.Current.Session["LOCALUSER"] = userModel;
            }
        }

        public UserModel GetUser()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session["LOCALUSER"] as UserModel
                : null;
        }

        public UserModel ClearUser()
        {
            StoreAuthorizedUser(null);
            StoreToken(null);

            return GetUser();
        }

        public string GetHttpSessionId()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session.SessionID
                : null;
        }

        //public string GetUserIpAddress()
        //{
        //    return System.Web.HttpContext.Current != null
        //        ? System.Web.HttpContext.Current.ClientIpAddress()
        //        : null;
        //}

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