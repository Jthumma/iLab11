using System;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;
using iLab11ProtoNg.Provider.WcfServices.bindings.interfaces;
using iLab11ProtoNg.Provider.WcfServices.eDocMtomService;

namespace iLab11ProtoNg.Provider.WcfServices.adapters
{
    public class EDocClientAdapter : IEDocClientAdapter, IDisposable
    {
        private readonly ECMServiceSoapClient _ecmServiceSoapClient;

        public EDocClientAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _ecmServiceSoapClient = new ECMServiceSoapClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void GetPolicies()
        {
            _ecmServiceSoapClient.SearchPolicyDocuments("");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _ecmServiceSoapClient.Close();
            }
            // free native resources
        }
    }
}