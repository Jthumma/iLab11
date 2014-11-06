using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.domain;

namespace iLab11ProtoNg.Core.Domain.interfaces.provider
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