using System.Collections.Generic;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface ICprProviderAdapter
    {
        string GetProperty(string propertyName);
        bool PropertyExists(string propertyName);
        string GetEnvLevel();
        void RefreshCpr();
        List<LookupListItem> GetCprList();
    }
}