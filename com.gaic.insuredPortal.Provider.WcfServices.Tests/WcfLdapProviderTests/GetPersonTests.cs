using com.gaic.insuredPortal.Core.Domain.models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.gaic.insuredPortal.Provider.WcfServices.Tests.WcfLdapProviderTests
{
    [TestClass]
    public class GetPersonTests : IntgTestBaseWcfServicesProvider
    {
        [TestMethod]
        public void GetPerson_ValidUserId_Should_Return_User()
        {
            UserModel user = _ldapProvider.GetPerson("taccountfis1", _token);
            user.Should().NotBeNull();
        }
    }
}