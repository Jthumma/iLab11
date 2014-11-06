using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfEDocProvider : IEDocProvider
    {
        private readonly IEDocClientAdapter _eDocClientAdapter;

        public WcfEDocProvider(IEDocClientAdapter eDocClientAdapter)
        {
            _eDocClientAdapter = eDocClientAdapter;
        }

        public List<PolicyModel> GetPolicies()
        {
            return _eDocClientAdapter.GetPolicies();
        }
    }
}