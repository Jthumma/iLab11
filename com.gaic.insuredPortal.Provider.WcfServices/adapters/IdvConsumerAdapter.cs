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

            //_idvConsumerServiceClient.authenticate();
            //_idvConsumerServiceClient.changePassword();
            //_idvConsumerServiceClient.checkDependencies();
            //_idvConsumerServiceClient.createUser();
            //_idvConsumerServiceClient.deleteUser();
            //_idvConsumerServiceClient.describePasswordPolicy();
            //_idvConsumerServiceClient.generatePassword();
            //_idvConsumerServiceClient.getChallengesForSetup();
            //_idvConsumerServiceClient.getRandomChallenges();
            //_idvConsumerServiceClient.getUserByDn();
            //_idvConsumerServiceClient.getUserByHid();
            //_idvConsumerServiceClient.getUserByVid();
            //_idvConsumerServiceClient.getVersion();
            
            //_idvConsumerServiceClient.refreshCprProperties();
            //_idvConsumerServiceClient.resetPassword();
            //_idvConsumerServiceClient.saveChallengeResponses();
            //_idvConsumerServiceClient.search();
            //_idvConsumerServiceClient.updateUser();
            //_idvConsumerServiceClient.userHasSetupResponses();
            //_idvConsumerServiceClient.validateChallegeResponses();

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

        public bool Ping(string token)
        {
            var value = _idvConsumerServiceClient.ping();
            return value > 0;
        }
    }
}