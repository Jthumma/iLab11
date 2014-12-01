using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.gaic.insuredPortal.Provider.WcfServices.Tests.FdwInquiryProviderTests
{
    [TestClass]
    public class GetPolicyInfoTests : IntgTestBaseWcfServicesProvider
    {
        [TestMethod]
        public void GetPolicyInfo_Valid_Symbol_Should_ReturnPolicies()
        {
            List<PolicyModel> policies = _fdwInquiryProvider.GetPolicyInfo(new SearchModel {InsuredName = "Dirk"},
                _token);
            policies.Should().NotBeNullOrEmpty();
        }
    }
}