using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.domain;
using iLab11ProtoNg.Core.Domain.interfaces.provider;

namespace iLab11ProtoNg.Provider.HttpContext
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
            User user = GetUser();
            return user != null ? user.UniversalId : null;
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

        public void StoreAuthorizedUser(User user)
        {
            if (System.Web.HttpContext.Current != null)
            {
                System.Web.HttpContext.Current.Session["LOCALUSER"] = user;
            }
        }

        public User GetUser()
        {
            return System.Web.HttpContext.Current != null
                ? System.Web.HttpContext.Current.Session["LOCALUSER"] as User
                : null;
        }

        public User ClearUser()
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
    }
}