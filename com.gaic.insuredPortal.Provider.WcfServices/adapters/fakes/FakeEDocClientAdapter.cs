using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeEDocClientAdapter : IEDocClientAdapter
    {
        public List<PolicyModel> GetPolicies()
        {
            var list = new List<PolicyModel>
            {
                new PolicyModel {PolicyId = 1, Product = "BAP", Number = "2345671", Mod = 0, Version = 0},
                new PolicyModel {PolicyId = 2, Product = "ABC", Number = "8723089", Mod = 0, Version = 1}
            };
            return list;

        }
    }
}