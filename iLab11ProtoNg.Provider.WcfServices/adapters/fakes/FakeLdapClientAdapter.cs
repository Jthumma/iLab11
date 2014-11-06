using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain.domain;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.adapters.fakes
{
    public class FakeLdapClientAdapter : ILdapClientAdapter
    {
        public User GetPerson(string userId, string token)
        {
            return new User {UserId = userId, Token = token, FirstName = "Test", LastName = "Account"};
        }

        public bool Ping(string token)
        {
            return true;
        }

        public List<User> GetPersonsInRole(string roleNameWithPrefix, string token)
        {
            return null;
        }

        public List<string> GetGroupsForPerson(string userId, string token)
        {
            return null;
        }
    }
}