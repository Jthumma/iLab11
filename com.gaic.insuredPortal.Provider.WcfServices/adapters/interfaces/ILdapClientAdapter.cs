using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.domain;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface ILdapClientAdapter
    {
        User GetPerson(string userId, string token);
        bool Ping(string token);
        List<User> GetPersonsInRole(string roleName, string token);
        List<string> GetGroupsForPerson(string userId, string token);
    }
}