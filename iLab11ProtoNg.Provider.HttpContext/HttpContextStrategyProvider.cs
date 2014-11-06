using System.Collections.Generic;
using System.Linq;
using iLab11ProtoNg.Core.Domain.domain;
using iLab11ProtoNg.Core.Domain.interfaces.provider;

namespace iLab11ProtoNg.Provider.HttpContext
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


        public User GetUser(bool checkSiteMinderOnly)
        {
            if (checkSiteMinderOnly) return _contextAdapters[ContextType.SiteMinder].GetUser();

            User user = CurrentContext.GetUser();
            return user;
        }

        public User ClearUser()
        {
            User user = CurrentContext.ClearUser();
            return user;
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

        public void StoreAuthorizedUser(User user)
        {
            CurrentContext.StoreAuthorizedUser(user);
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