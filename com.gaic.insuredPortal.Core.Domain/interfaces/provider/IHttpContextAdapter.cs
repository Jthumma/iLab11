using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IHttpContextAdapter
    {
        ContextType ContextType { get; }
        UserModel GetUser();
        UserModel ClearUser();
        string GetUserName();
        string GetUserPwd();
        string GetUserUniversalId();
        List<string> GetUserGroups();
        string GetToken();
        bool StoreToken(string token);
        void StoreAuthorizedUser(UserModel userModel);
        string GetHttpSessionId();
        //string GetUserIpAddress();
        void ApplyPermissions(PermissionModel permission);
        PermissionModel GetPermissions();
    }
}