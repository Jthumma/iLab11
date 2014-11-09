using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfEdwPsarProvider : IEdwPsarProvider
    {
        private readonly IEdwPsarAdapter _edwPsarAdapter;

        public WcfEdwPsarProvider(IEdwPsarAdapter edwPsarAdapter)
        {
            _edwPsarAdapter = edwPsarAdapter;
        }

        public bool Ping(string token)
        {
            return _edwPsarAdapter.Ping(token);
        }
    }
}