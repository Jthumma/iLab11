using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IHttpContextStrategyProvider
    {
        UserModel GetUser(bool checkSiteMinderOnly);
        UserModel ClearUser();
        string GetUserName();
        string GetUserPwd();
        string GetUserUniversalId();
        List<string> GetUserGroups();
        string GetUserToken();
        void StoreToken(string token);
        void StoreAuthorizedUser(UserModel userModel);
        string GetHttpSessionId();
        void ApplyPermissions(PermissionModel permission);
        PermissionModel GetPermissions();
    }
}