using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.enums;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class BackOfficeStatCompFakeEDocClientAdapter : IBuBackOfficeFakeEDocClientAdapter
    {
        public BusinessUnitEnum BusinessUnitEnum
        {
            get { return BusinessUnitEnum.StrategicComp; }
        }

        public List<PolicyModel> GetPolicies()
        {
            var policies = new List<PolicyModel>
            {
                
            };
            return policies;
        }
    }
}