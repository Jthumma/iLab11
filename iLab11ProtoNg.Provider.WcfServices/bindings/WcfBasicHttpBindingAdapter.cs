using System.ServiceModel;
using iLab11ProtoNg.Provider.WcfServices.bindings.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.bindings
{
    public class WcfBasicHttpBindingAdapter : IWcfHttpBindingAdapter
    {
        public WcfBasicHttpBindingAdapter()
        {
            Binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            Binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            Binding.MaxReceivedMessageSize = 2147483647;
        }

        public BasicHttpBinding Binding { get; set; }
    }
}