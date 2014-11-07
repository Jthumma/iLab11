using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface ILdapClientAdapter
    {
        UserModel GetPerson(string userId, string token);
        bool Ping(string token);
        List<UserModel> GetPersonsInRole(string roleName, string token);
        List<string> GetGroupsForPerson(string userId, string token);
    }
}