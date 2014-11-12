using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.BcPortalService;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class BcPortalAdapter : IBcPortalAdapter, IDisposable
    {
        private readonly AgentPortalBillingServicesClient _agentPortalBillingServicesClient;

        public BcPortalAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _agentPortalBillingServicesClient = new AgentPortalBillingServicesClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_agentPortalBillingServicesClient.InnerChannel, token);
            var version = _agentPortalBillingServicesClient.getVersion();
            return !String.IsNullOrEmpty(version);
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
                _agentPortalBillingServicesClient.Close();
            }
            // free native resources
        }
    }
}