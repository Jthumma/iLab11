using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.domain;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IHttpContextAdapter
    {
        ContextType ContextType { get; }
        User GetUser();
        User ClearUser();
        string GetUserName();
        string GetUserPwd();
        string GetUserUniversalId();
        List<string> GetUserGroups();
        string GetToken();
        bool StoreToken(string token);
        void StoreAuthorizedUser(User user);
        string GetHttpSessionId();
        //string GetUserIpAddress();
    }
}