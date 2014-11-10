using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.gaic.insuredPortal.Provider.WcfServices.Tests.WcfeDocProviderTests
{
    [TestClass]
    public class SearchDocumentsTests : IntgTestBaseWcfServicesProvider
    {
        [TestMethod]
        public void SearchDocuments_Valid_PolicyNumber_Should_ReturnPolicies()
        {
            List<PolicyModel> policies = _eDocProvider.GetPolicies("0000000", _token);
            policies.Should().NotBeNullOrEmpty();
        }
    }
}