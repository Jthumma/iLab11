using System.ServiceModel;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.bindings
{
    public class WcfEndpointAddressAdapter : IWcfEndpointAddressAdapter
    {
        public WcfEndpointAddressAdapter(ICprProviderAdapter cprProviderAdapter, string cprKey)
        {
            string url = cprProviderAdapter.GetProperty(cprKey);
            EndpointAddress = new EndpointAddress(url);
        }

        public EndpointAddress EndpointAddress { get; set; }
    }
}