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

        public PolicyModel GetPolicyInfo()
        {
            //return _fdwInquiryAdapter.GetPolicyInfo();
            return null;
        }

    }
}
