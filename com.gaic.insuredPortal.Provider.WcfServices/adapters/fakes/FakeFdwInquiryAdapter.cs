using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeFdwInquiryAdapter : IFdwInquiryAdapter
    {
        public bool Ping(string token)
        {
            return true;
        }

        public List<PolicyModel> SearchFdw(SearchModel searchCriteria, string token)
        {
            return null;
        }
    }
}