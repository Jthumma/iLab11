using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeLdapClientAdapter : ILdapClientAdapter
    {
        public UserModel GetPerson(string userId, string token)
        {
            if (userId == "jtrucker")
            {
                return new UserModel {UserId = userId, Token = token, FirstName = "Joe", LastName = "Trucker"};
            }
            if (userId == "bjones")
            {
                return new UserModel {UserId = userId, Token = token, FirstName = "Bob", LastName = "Jones"};
            }
            if (userId == "jcorporate")
            {
                return new UserModel {UserId = userId, Token = token, FirstName = "Jane", LastName = "Corporate"};
            }
            if (userId == "aandy")
            {
                return new UserModel {UserId = userId, Token = token, FirstName = "Andy", LastName = "Agent"};
            }
            return userId == "bbetty"
                ? new UserModel {UserId = userId, Token = token, FirstName = "Betty", LastName = "Back Office"}
                : new UserModel {UserId = userId, Token = token, FirstName = "Test", LastName = "Account"};
        }

        public bool Ping(string token)
        {
            return true;
        }

        public List<UserModel> GetPersonsInRole(string roleNameWithPrefix, string token)
        {
            return null;
        }

        public List<string> GetGroupsForPerson(string userId, string token)
        {
            return null;
        }
    }
}