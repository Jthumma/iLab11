using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class GaicEmployeeTruckingFakeEDocClientAdapter : IBuGaicEmployeeFakeEDocClientAdapter
    {
        public BusinessUnits BusinessUnit
        {
            get { return BusinessUnits.Trucking; }
        }

        public List<PolicyModel> GetPolicies()
        {
            var policies = new List<PolicyModel>
            {
                FakePolicies.Gtp246210300,
                FakePolicies.Gtp246210400,
                FakePolicies.Gtp312948400
            };
            return policies;
        }
    }
}