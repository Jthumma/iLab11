using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.ProducerService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class ProducerClientAdapter : IProducerClientAdapter, IDisposable
    {
        private readonly ProducerWebServicePortTypeClient _producerWebServicePortTypeClient;

        public ProducerClientAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _producerWebServicePortTypeClient = new ProducerWebServicePortTypeClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_producerWebServicePortTypeClient.InnerChannel, token);
            var preqd = new ProducerRequestDTO_4
            {
                BusinessUnit = "Financial Institution Services",
                ProducerCode = "%"
            };
            var presdto = _producerWebServicePortTypeClient.getProducers_4(preqd);
            return presdto != null && presdto[0] != null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _producerWebServicePortTypeClient.Close();
            }
            // free native resources
        }
    }
}