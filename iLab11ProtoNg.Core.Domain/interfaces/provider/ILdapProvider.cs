using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.domain;

namespace iLab11ProtoNg.Core.Domain.interfaces.provider
{
    public interface ILdapProvider
    {
        User GetPerson(string userId, string token);
        List<User> GetPersonsInRole(string roleNameWithPrefix, string token);
        List<string> GetGroupsForPerson(string userId, string token);
        bool Ping(string token);
    }
}