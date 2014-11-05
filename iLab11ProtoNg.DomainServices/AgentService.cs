using iLab11ProtoNg.Core.Domain;

namespace iLab11ProtoNg.DomainServices
{
    public class AgentService : IAgentService
    {
        public AgentModel GetAgentInfo()
        {
            var agentInfo = new AgentModel
            {
                Name = "Agent Andy",
                AgencyName = "XYZ Agency",
                Address = new AddressModel {Line1 = "234 Line1", City = "Colorado Spring", State = "CO", Zip = "45202"}
            };
            return agentInfo;
        }
    }
}