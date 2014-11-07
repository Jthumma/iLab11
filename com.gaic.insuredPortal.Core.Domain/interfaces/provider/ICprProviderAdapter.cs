using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Core.Domain.interfaces.provider
{
    public interface ICprProviderAdapter
    {
        string GetProperty(string propertyName);
        bool PropertyExists(string propertyName);
        string GetEnvLevel();
        void RefreshCpr();
        List<ListItemModel> GetCprList();
    }
}