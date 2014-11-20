using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfProducerProvider : IProducerProvider
    {
        private readonly IProducerClientAdapter _producerClientAdapter;

        public WcfProducerProvider(IProducerClientAdapter producerClientAdapter)
        {
            _producerClientAdapter = producerClientAdapter;
        }

        public bool Ping(string token)
        {
            return _producerClientAdapter.Ping(token);
        }
    }
}