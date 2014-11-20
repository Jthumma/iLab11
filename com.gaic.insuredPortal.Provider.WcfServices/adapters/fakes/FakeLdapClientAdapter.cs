using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeLdapClientAdapter : ILdapClientAdapter
    {
        public UserModel GetPerson(string userId, string token)
        {
            //TRUCKING
            if (userId == "jtrucker")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Joe",
                    LastName = "Trucker",
                    BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                    Roles = new List<RoleItemModel> {RoleItemModel.Insured}
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
                    BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                    Roles = new List<RoleItemModel> {RoleItemModel.MotorCarrier}
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
                    BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                    Roles = new List<RoleItemModel> {RoleItemModel.GaicEmployee}
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
                    BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                    Roles = new List<RoleItemModel> {RoleItemModel.Agent}
                };
            }
            if (userId == "bbetty")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Betty",
                    LastName = "Back Office",
                    BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                    Roles = new List<RoleItemModel> {RoleItemModel.BackOffice}
                };
            }

            //STRATEGICCOMP
            if (userId == "jcorporate")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Jane",
                    LastName = "Corporate",
                    BusinessUnit = BusinessUnits.StrategicComp.GetDescription(),
                    Roles = new List<RoleItemModel> { RoleItemModel.OwnerCorporate }
                };
            }
            if (userId == "mhendrick")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Matt",
                    LastName = "Hendrick",
                    BusinessUnit = BusinessUnits.StrategicComp.GetDescription(),
                    Roles = new List<RoleItemModel> { RoleItemModel.GaicEmployee }
                };
            }
            if (userId == "asteve")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Steve",
                    LastName = "Agent",
                    BusinessUnit = BusinessUnits.StrategicComp.GetDescription(),
                    Roles = new List<RoleItemModel> { RoleItemModel.Agent }
                };
            }
            if (userId == "snate")
            {
                return new UserModel
                {
                    UserId = userId,
                    Token = token,
                    FirstName = "Sue",
                    LastName = "Nate",
                    BusinessUnit = BusinessUnits.StrategicComp.GetDescription(),
                    Roles = new List<RoleItemModel> { RoleItemModel.BackOffice }
                };
            }

            return new UserModel
            {
                UserId = userId,
                Token = token,
                FirstName = "Test",
                LastName = "Account",
                BusinessUnit = BusinessUnits.Trucking.GetDescription(),
                Roles = new List<RoleItemModel> {RoleItemModel.NoAccess}
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