using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain;
using iLab11ProtoNg.Core.Domain.domain;

namespace iLab11ProtoNg.Provider.WcfServices.adapters.interfaces
{
    public interface ILdapClientAdapter
    {
        User GetPerson(string userId, string token);
        bool Ping(string token);
        List<User> GetPersonsInRole(string roleName, string token);
        List<string> GetGroupsForPerson(string userId, string token);
    }
}