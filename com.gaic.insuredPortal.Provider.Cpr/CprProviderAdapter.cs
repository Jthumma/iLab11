using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using Utility.CPR;

namespace com.gaic.insuredPortal.Provider.Cpr
{
    public class CprProviderAdapter : ICprProviderAdapter
    {
        private readonly CustomCprPropertyPlaceholderConfigurer _cprPropertyConfigurer;
        private CPRPropertyProvider _cprProvider;

        public CprProviderAdapter(string cprNamespace)
        {
            _cprProvider = new CPRPropertyProvider();
            _cprPropertyConfigurer = new CustomCprPropertyPlaceholderConfigurer
            {
                Namespace = cprNamespace,
                CprProvider = _cprProvider
            };
        }

        public string GetProperty(string propertyName)
        {
            return _cprProvider.getProperty(_cprPropertyConfigurer.Namespace + propertyName);
        }

        public bool PropertyExists(string propertyName)
        {
            List<LookupListItem> list = GetCprList();
            if (!Utils.HasRows<LookupListItem>(list)) return false;
            return list.FirstOrDefault(x => x.Code == _cprPropertyConfigurer.Namespace + propertyName) != null;
        }

        public string GetEnvLevel()
        {
            return CPRPropertyProvider.getEnvLevel();
        }

        public void RefreshCpr()
        {
            _cprProvider = new CPRPropertyProvider(_cprPropertyConfigurer.Namespace, GetEnvLevel());
        }

        public List<LookupListItem> GetCprList()
        {
            Dictionary<string, PropertyValue> dict = _cprProvider.getCPRDictionary();
            IOrderedEnumerable<KeyValuePair<string, PropertyValue>> sortedDict = dict.Where(
                keyValuePair => keyValuePair.Key.StartsWith(_cprPropertyConfigurer.Namespace))
                .OrderBy(keyValuePair => keyValuePair.Key.ToLower());

            return sortedDict.Select(keyValuePair => new LookupListItem(keyValuePair.Key, keyValuePair.Value)).ToList();
        }
    }
}