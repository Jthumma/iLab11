using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.DomainServices
{
    public class PolicyService : IPolicyService
    {
        private readonly IEDocProvider _eDocProvider;
        private readonly IFdwInquiryProvider _fdwInquiryProvider;

        public PolicyService(IEDocProvider eDocProvider, IFdwInquiryProvider fdwInquiryProvider)
        {
            _eDocProvider = eDocProvider;
            _fdwInquiryProvider = fdwInquiryProvider;
        }

        public List<PolicyModel> GetPolicies(string policyNumber, UserModel user)
        {
            return _eDocProvider.GetPolicies(policyNumber, user);
        }

        public PolicyModel  GetPolicyInfo()
        {

            //return _fdwInquiryProvider.GetPolicyInfo();
            return null;
        }

    }
}