using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.domain;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
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