using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.IdvConsumerService;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class IdvConsumerAdapter : IIdvConsumerAdapter, IDisposable
    {
        private readonly IdvConsumerServiceClient _idvConsumerServiceClient;

        public IdvConsumerAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _idvConsumerServiceClient = new IdvConsumerServiceClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);


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
                _idvConsumerServiceClient.Close();
            }
            // free native resources
        }
    }
}