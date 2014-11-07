using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface ILdapProvider
    {
        UserModel GetPerson(string userId, string token);
        List<UserModel> GetPersonsInRole(string roleNameWithPrefix, string token);
        List<string> GetGroupsForPerson(string userId, string token);
        bool Ping(string token);
    }
}