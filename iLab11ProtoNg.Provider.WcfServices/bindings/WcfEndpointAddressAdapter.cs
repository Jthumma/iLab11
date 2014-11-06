using System.ServiceModel;
using iLab11ProtoNg.Provider.Cpr;
using iLab11ProtoNg.Provider.WcfServices.bindings.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.bindings
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