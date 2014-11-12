using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.FdwInquiryService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class FdwInquiryAdapter : IFdwInquiryAdapter, IDisposable
    {
        private readonly FdwInquiryServiceClient _fdwInquiryServiceClient;

        public FdwInquiryAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _fdwInquiryServiceClient = new FdwInquiryServiceClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_fdwInquiryServiceClient.InnerChannel, token);
            var value = _fdwInquiryServiceClient.ping();
            return value > 0;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _fdwInquiryServiceClient.Close();
            }
            // free native resources
        }
    }
}