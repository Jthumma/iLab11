using iLab11ProtoNg.Core.Domain.interfaces.provider;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.providers
{
    public class WcfEDocProvider : IEDocProvider
    {
        private readonly IEDocClientAdapter _eDocClientAdapter;

        public WcfEDocProvider(IEDocClientAdapter eDocClientAdapter)
        {
            _eDocClientAdapter = eDocClientAdapter;
        }

        public void GetPolicies()
        {
            _eDocClientAdapter.GetPolicies();
        }
    }
}