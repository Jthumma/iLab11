using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfBcPortalProvider : IBcPortalProvider
    {
        private readonly IBcPortalAdapter _bcPortalAdapter;

        public WcfBcPortalProvider(IBcPortalAdapter bcPortalAdapter)
        {
            _bcPortalAdapter = bcPortalAdapter;
        }

        public bool Ping(string token)
        {
            return _bcPortalAdapter.Ping(token);
        }
    }
}