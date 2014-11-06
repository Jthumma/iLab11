using iLab11ProtoNg.Core.Domain.interfaces.provider;
using iLab11ProtoNg.Provider.WcfServices.adapters;
using iLab11ProtoNg.Provider.WcfServices.adapters.fakes;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;
using iLab11ProtoNg.Provider.WcfServices.bindings;
using iLab11ProtoNg.Provider.WcfServices.bindings.interfaces;
using iLab11ProtoNg.Provider.WcfServices.providers;
using Ninject.Modules;

namespace iLab11ProtoNg.Provider.WcfServices
{
    public class WcfServicesBootstrap : NinjectModule
    {
        public override void Load()
        {
            //PROVIDERS
            RegisterProviders();

            //ADAPTERS
            //RegisterAdapters();
            RegisterFakeAdapters();

            //BINDINGS
            RegisterBindings();

            //ENDPOINTS
            RegisterEndpoints();
        }

        private void RegisterProviders()
        {
            Bind<ISingleSignonProvider>().To<WcfSingleSignonProvider>();
            Bind<ILdapProvider>().To<WcfLdapProvider>();
            Bind<IEDocProvider>().To<WcfEDocProvider>();
        }

        private void RegisterAdapters()
        {
            Bind<ISsoLoginPortClientAdapter>().To<SsoLoginPortClientAdapter>().InSingletonScope();
            Bind<ILdapClientAdapter>().To<LdapClientAdapter>().InSingletonScope();
            Bind<IEDocClientAdapter>().To<EDocClientAdapter>().InSingletonScope();
        }

        private void RegisterFakeAdapters()
        {
            Bind<ISsoLoginPortClientAdapter>().To<FakeSsoLoginPortClientAdapter>().InSingletonScope();
            Bind<ILdapClientAdapter>().To<FakeLdapClientAdapter>().InSingletonScope();
            Bind<IEDocClientAdapter>().To<FakeEDocClientAdapter>().InSingletonScope();
        }

        private void RegisterBindings()
        {
            //use secured binding for all services except SSO service
            Bind<IWcfHttpBindingAdapter>().To<WcfSecuredBasicHttpBindingAdapter>();

            Bind<IWcfHttpBindingAdapter>()
                .To<WcfBasicHttpBindingAdapter>()
                .WhenInjectedInto<SsoLoginPortClientAdapter>();
        }

        private void RegisterEndpoints()
        {
            //SSO
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<SsoLoginPortClientAdapter>()
                .WithConstructorArgument("cprKey", "service.ssoLogin.url");

            //LDAP
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<LdapClientAdapter>()
                .WithConstructorArgument("cprKey", "service.ldap.url");

            //eDOC
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<EDocClientAdapter>()
                .WithConstructorArgument("cprKey", "service.eDoc.url");
        }
    }
}