using System.Collections.Generic;
using iLab11ProtoNg.Models;

namespace iLab11ProtoNg.DomainServices
{
    public class PolicyService : IPolicyService
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