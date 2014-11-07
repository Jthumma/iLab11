using System;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.Cpr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace com.gaic.insuredPortal.Provider.WcfServices.Tests
{
    [TestClass]
    public class IntgTestBaseWcfServicesProvider : IDisposable
    {
        private readonly IKernel _kernel;
        protected ILdapProvider _ldapProvider;
        protected IIdvConsumerProvider _idvConsumerProvider;
        protected ISingleSignonProvider _singleSignonProvider;
        protected string _token;

        public IntgTestBaseWcfServicesProvider()
        {
            _kernel = new StandardKernel(new CprBootstrap(), new WcfServicesBootstrap());

            WcfServiceMapper.Initialize();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [TestInitialize]
        public virtual void Setup()
        {
            _singleSignonProvider = _kernel.Get<ISingleSignonProvider>();
            _ldapProvider = _kernel.Get<ILdapProvider>();

            _token = _singleSignonProvider.GetSingleSignonToken("taccountfis1", "Winter1");
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            // dispose managed resources
            if (_kernel != null) _kernel.Dispose();

            // free native resources
        }
    }
}