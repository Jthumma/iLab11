using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfIdvConsumerProvider : IIdvConsumerProvider
    {
        private readonly IIdvConsumerAdapter _idvConsumerAdapter;

        public WcfIdvConsumerProvider(IIdvConsumerAdapter idvConsumerAdapter)
        {
            _idvConsumerAdapter = idvConsumerAdapter;
        }

        public bool Ping(string token)
        {
            return _idvConsumerAdapter.Ping(token);
        }
    }
}