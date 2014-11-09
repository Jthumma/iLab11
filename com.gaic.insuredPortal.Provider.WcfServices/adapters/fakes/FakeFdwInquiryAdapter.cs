using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeFdwInquiryAdapter : IFdwInquiryAdapter
    {
        public bool Ping(string token)
        {
            return true;
        }
    }
}