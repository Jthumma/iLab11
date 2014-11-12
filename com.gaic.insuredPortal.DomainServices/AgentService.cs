using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class AgentService : IAgentService
    {
        public AgentModel GetAgentInfo(UserModel user)
        {
            AgentModel agent = null;
            if (user.Roles.Contains(RoleItemModel.GaicEmployee))
            {
                agent = new AgentModel
                {
                    AgencyName = "BB&T Webb Insurance",
                    AgentCode = "8732489",
                    Name = "Bob Wills",
                    Address =
                        new AddressModel
                        {
                            City = "Statesville",
                            State = "NC",
                            Zip = "28687"
                        },
                    Contact =
                        new ContactModel {Phone = "8567891235", Fax = "8567896987", Email = "bbtwebb@insurance.com"}
                };
            }
            else
            {
                agent = new AgentModel
                {
                    AgencyName = "Brands Insurance Agency",
                    AgentCode = "234737",
                    Name = "Steve Hauser",
                    Address =
                        new AddressModel
                        {
                            Line1 = "6449 Allen Road",
                            City = "West Chester",
                            State = "OH",
                            Zip = "45069"
                        },
                    Contact = new ContactModel {Phone = "5131234567", Email = "brandsins@agency.com"}
                };
            }
            return agent;
        }
    }
}