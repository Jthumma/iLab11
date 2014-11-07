using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.Cpr
{
    public class CprProvider : ICprProvider
    {
        private readonly ICprProviderAdapter _cprProviderAdapter;

        public CprProvider(ICprProviderAdapter cprProviderAdapter)
        {
            _cprProviderAdapter = cprProviderAdapter;
        }

        public string GetProperty(string propertyName)
        {
            return _cprProviderAdapter.GetProperty(propertyName);
        }

        public bool PropertyExists(string propertyName)
        {
            return _cprProviderAdapter.PropertyExists(propertyName);
        }

        public string GetEnvLevel()
        {
            return _cprProviderAdapter.GetEnvLevel();
        }

        public void RefreshCpr()
        {
            _cprProviderAdapter.RefreshCpr();
        }

        public List<ListItemModel> GetCprList()
        {
            return _cprProviderAdapter.GetCprList();
        }
    }
}