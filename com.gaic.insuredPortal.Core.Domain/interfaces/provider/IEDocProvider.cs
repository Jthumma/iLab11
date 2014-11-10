using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IEDocProvider
    {
        bool Ping(string token);
        List<PolicyModel> GetPolicies(string policyNumber, string token);
    }
}