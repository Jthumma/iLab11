using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.enums;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class AgentStatCompFakeEDocClientAdapter : IBuAgentFakeEDocClientAdapter
    {
        public BusinessUnitEnum BusinessUnitEnum
        {
            get { return BusinessUnitEnum.StrategicComp; }
        }

        public List<PolicyModel> GetPolicies()
        {
            var policies = new List<PolicyModel>
            {
                FakePolicies.Gtp246210200,
                FakePolicies.Gtp312948400
            };
            return policies;
        }
    }
}