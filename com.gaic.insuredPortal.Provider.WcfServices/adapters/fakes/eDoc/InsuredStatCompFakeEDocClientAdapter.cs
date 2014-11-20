using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class InsuredStatCompFakeEDocClientAdapter : IBuInsuredFakeEDocClientAdapter
    {
        public BusinessUnits BusinessUnit
        {
            get { return BusinessUnits.StrategicComp; }
        }

        public List<PolicyModel> GetPolicies()
        {
            var policies = new List<PolicyModel>
            {
                FakePolicies.Wc170881601
            };
            return policies;
        }
    }
}