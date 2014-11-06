using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.domain;

namespace iLab11ProtoNg.Core.Domain.interfaces.provider
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