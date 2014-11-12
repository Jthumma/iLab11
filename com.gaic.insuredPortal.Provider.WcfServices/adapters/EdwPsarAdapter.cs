using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.EdwPsarService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class EdwPsarAdapter : IEdwPsarAdapter, IDisposable
    {
        private readonly EDWPolicySearchAndRetrievalServiceFacadeClient _edwPolicySearchAndRetrievalServiceFacadeClient;

        public EdwPsarAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _edwPolicySearchAndRetrievalServiceFacadeClient =
                new EDWPolicySearchAndRetrievalServiceFacadeClient(bindingAdapter.Binding,
                    endpointAddressAdapter.EndpointAddress);
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_edwPolicySearchAndRetrievalServiceFacadeClient.InnerChannel, token);
            var value = _edwPolicySearchAndRetrievalServiceFacadeClient.ping();
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
                _edwPolicySearchAndRetrievalServiceFacadeClient.Close();
            }
            // free native resources
        }
    }
}