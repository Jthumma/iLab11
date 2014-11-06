using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain;

namespace iLab11ProtoNg.Provider.Cpr
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

        public List<LookupListItem> GetCprList()
        {
            return _cprProviderAdapter.GetCprList();
        }
    }
}