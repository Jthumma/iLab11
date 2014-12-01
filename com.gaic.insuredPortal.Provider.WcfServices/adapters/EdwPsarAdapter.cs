using System;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.EdwPsarService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class EdwPsarAdapter : IEdwPsarAdapter, IDisposable
    {
        private readonly EDWPolicySearchAndRetrievalServiceFacadeClient _edwClient;

        public EdwPsarAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _edwClient =
                new EDWPolicySearchAndRetrievalServiceFacadeClient(bindingAdapter.Binding,
                    endpointAddressAdapter.EndpointAddress);

            //_edwClient.retrieveEDWPolicyTerm()
            //_edwClient.searchAndRetrieveLatestEDWPolicyTerm();
            //_edwClient.searchEDW();
            

        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_edwClient.InnerChannel, token);
            var value = _edwClient.ping();
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
                _edwClient.Close();
            }
            // free native resources
        }
    }
}