using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.gaic.insuredPortal.Provider.WcfServices.Tests
{
    [TestClass]
    public class PingServiceProviderTests : IntgTestBaseWcfServicesProvider
    {
        [TestMethod]
        public void Ping_Ldap_Service()
        {
            var status = _ldapProvider.Ping(_token);
            status.Should().BeTrue();
        }

        //[TestMethod]
        //public void Ping_bcPortal_Service()
        //{
        //    var status = _bcPortalProvider.Ping(_token);
        //    status.Should().BeTrue();
        //}

        [TestMethod]
        public void Ping_eDoc_Service()
        {
            var status = _eDocProvider.Ping(_token);
            status.Should().BeTrue();
        }

        [TestMethod]
        public void Ping_edwPsar_Service()
        {
            var status = _edwPsarProvider.Ping(_token);
            status.Should().BeTrue();
        }

        [TestMethod]
        public void Ping_idvConsumer_Service()
        {
            var status = _idvConsumerProvider.Ping(_token);
            status.Should().BeTrue();
        }
    }
}