using System.Collections.Generic;
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
            return _eDocProvider.GetPolicies();
        }
    }
}