using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface IEDocClientAdapter
    {
        bool Ping(string token);
        List<PolicyModel> GetPolicies(string policyNumber, string token);
    }
}