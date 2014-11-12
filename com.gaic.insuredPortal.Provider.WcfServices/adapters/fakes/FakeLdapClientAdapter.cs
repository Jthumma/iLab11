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
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Joe",
                    LastName = "Trucker",
                    Roles = new List<RoleItemModel> {RoleItemModel.Insured}
                };
            }
            if (userId == "bjones")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Bob",
                    LastName = "Jones",
                    Roles = new List<RoleItemModel> {RoleItemModel.GaicEmployee}
                };
            }
            if (userId == "jcorporate")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Jane",
                    LastName = "Corporate",
                    Roles = new List<RoleItemModel> {RoleItemModel.OwnerCorporate}
                };
            }
            if (userId == "tindy")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Team",
                    LastName = "Indy",
                    Roles = new List<RoleItemModel> { RoleItemModel.TeamIndy }
                };
            }
            if (userId == "aandy")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Andy",
                    LastName = "Agent",
                    Roles = new List<RoleItemModel> {RoleItemModel.Agent}
                };
            }
            return userId == "bbetty"
                ? new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Betty",
                    LastName = "Back Office",
                    Roles = new List<RoleItemModel> {RoleItemModel.BackOffice}
                }
                : new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Test",
                    LastName = "Account",
                    Roles = new List<RoleItemModel> {RoleItemModel.ViewAll}
                };
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