﻿using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class PolicyService : IPolicyService
    {
        private readonly IEDocProvider _eDocProvider;

        public PolicyService(IEDocProvider eDocProvider)
        {
            _eDocProvider = eDocProvider;
        }

        public List<PolicyModel> GetPolicies()
        {
            //var list = new List<PolicyModel>
            //{
            //    new PolicyModel {PolicyId = 1, Product = "BAP", Number = "2345671", Mod = 0, Version = 0},
            //    new PolicyModel {PolicyId = 2, Product = "ABC", Number = "8723089", Mod = 0, Version = 1}
            //};
            //return list;

            return _eDocProvider.GetPolicies();
        }
    }
}