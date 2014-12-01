using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfFdwInquiryProvider: IFdwInquiryProvider
    {
        private readonly IFdwInquiryAdapter _fdwInquiryAdapter;

        public WcfFdwInquiryProvider(IFdwInquiryAdapter fdwInquiryAdapter)
        {
            _fdwInquiryAdapter = fdwInquiryAdapter;
        }

        public List<PolicyModel> GetPolicyInfo(SearchModel searchCriteria, string token)
        {
            return _fdwInquiryAdapter.SearchFdw(searchCriteria, token);
            
        }

        public bool Ping(string token)
        {
            return _fdwInquiryAdapter.Ping(token);
        }
    }
}
