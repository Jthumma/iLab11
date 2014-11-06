using System;
using System.ServiceModel;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.bindings
{
    public class WcfSecuredBasicHttpBindingAdapter : IWcfHttpBindingAdapter
    {
        public WcfSecuredBasicHttpBindingAdapter()
        {
            Binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            Binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;
            Binding.MaxReceivedMessageSize = 2147483647;
            Binding.ReceiveTimeout = new TimeSpan(0, 0, 3, 0);
            Binding.SendTimeout = new TimeSpan(0, 0, 3, 0);
        }

        public BasicHttpBinding Binding { get; set; }
    }
}