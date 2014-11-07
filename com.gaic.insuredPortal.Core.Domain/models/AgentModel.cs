using System.Collections.Generic;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class AgentModel
    {
        public string Name { get; set; }
        public string AgencyName { get; set; }
        public AddressModel Address { get; set; }
        public List<PolicyModel> Policies { get; set; }
    }
}