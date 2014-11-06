using System.ServiceModel;
using iLab11ProtoNg.Provider.WcfServices.bindings.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.bindings
{
    public class WcfBasicNoneHttpBindingAdapter : IWcfHttpBindingAdapter
    {
        public WcfBasicNoneHttpBindingAdapter()
        {
            Binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            Binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            Binding.Security.Mode = BasicHttpSecurityMode.None;
            Binding.MaxReceivedMessageSize = 2147483647;
        }

        public BasicHttpBinding Binding { get; set; }
    }
}