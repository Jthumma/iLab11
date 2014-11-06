using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IEDocProvider
    {
        List<PolicyModel> GetPolicies();
    }
}