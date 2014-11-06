using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain;

namespace iLab11ProtoNg.Provider.Cpr
{
    public interface ICprProvider
    {
        string GetProperty(string propertyName);
        bool PropertyExists(string propertyName);
        string GetEnvLevel();
        void RefreshCpr();
        List<LookupListItem> GetCprList();
    }
}