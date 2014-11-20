using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public interface IBuGaicEmployeeFakeEDocClientAdapter
    {
        BusinessUnits BusinessUnit { get; }
        List<PolicyModel> GetPolicies();
    }
}