using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.domain;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IHttpContextStrategyProvider
    {
        User GetUser(bool checkSiteMinderOnly);
        User ClearUser();
        string GetUserName();
        string GetUserPwd();
        string GetUserUniversalId();
        List<string> GetUserGroups();
        string GetUserToken();
        void StoreToken(string token);
        void StoreAuthorizedUser(User user);
        string GetHttpSessionId();
    }
}