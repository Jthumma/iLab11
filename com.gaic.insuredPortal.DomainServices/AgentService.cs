using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class AgentService : IAgentService
    {
        public ProducerModel GetAgentInfo(UserModel user)
        {
            ProducerModel producer = null;
            if (user.Roles.Contains(RoleItemModel.GaicEmployee))
            {
                producer = new ProducerModel
                {
                    AgencyName = "BB&T Webb Insurance",
                    Number = "8732489",
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
                producer = new ProducerModel
                {
                    AgencyName = "Brands Insurance Agency",
                    Number = "234737",
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
            return producer;
        }
    }
}