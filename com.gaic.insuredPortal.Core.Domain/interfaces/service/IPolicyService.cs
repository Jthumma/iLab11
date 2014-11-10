using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.service
{
    public interface IPolicyService
    {
        List<PolicyModel> GetPolicies(string policyNumber, string token);
    }
}