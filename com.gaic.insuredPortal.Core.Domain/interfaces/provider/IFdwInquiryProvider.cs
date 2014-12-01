using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface IFdwInquiryProvider
    {
        bool Ping(string token);
        List<PolicyModel> GetPolicyInfo(SearchModel searchCriteria, string token);
    }
}