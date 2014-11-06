using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.domain;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface ILdapProvider
    {
        User GetPerson(string userId, string token);
        List<User> GetPersonsInRole(string roleNameWithPrefix, string token);
        List<string> GetGroupsForPerson(string userId, string token);
        bool Ping(string token);
    }
}