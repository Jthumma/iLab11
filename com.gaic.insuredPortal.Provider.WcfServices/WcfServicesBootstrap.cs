using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Provider.WcfServices.adapters;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.providers;
using com.gaic.insuredPortal.Provider.WcfServices.providers.permissions;
using com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters;
using Ninject;
using Ninject.Modules;

namespace com.gaic.insuredPortal.Provider.WcfServices
{
    public class WcfServicesBootstrap : NinjectModule
    {
        public override void Load()
        {
            var cprProvider = Kernel.Get<ICprProvider>();

            //PROVIDERS
            RegisterProviders();

            //ADAPTERS
            const string useFakeServicesKey = "serviceAdapters.useFakes";
            bool useFakeServices = cprProvider.PropertyExists(useFakeServicesKey) &&
                                   bool.Parse(cprProvider.GetProperty(useFakeServicesKey));

            if (useFakeServices)
            RegisterFakeAdapters();
            else
                RegisterAdapters();


            //BINDINGS
            RegisterBindings();

            //ENDPOINTS
            RegisterEndpoints();

            //PERMISSIONS
            RegisterPermissions();
        }

        private void RegisterProviders()
        {
            Bind<ISingleSignonProvider>().To<WcfSingleSignonProvider>();
            Bind<ILdapProvider>().To<WcfLdapProvider>();
            Bind<IEDocProvider>().To<WcfEDocProvider>();
            Bind<IIdvConsumerProvider>().To<WcfIdvConsumerProvider>();
            Bind<IBcPortalProvider>().To<WcfBcPortalProvider>();
            Bind<IEdwPsarProvider>().To<WcfEdwPsarProvider>();
            Bind<IPermissionProvider>().To<PermissionProvider>();
            Bind<IFdwInquiryProvider>().To<WcfFdwInquiryProvider>();
        }

        private void RegisterAdapters()
        {
            Bind<ISsoLoginPortClientAdapter>().To<SsoLoginPortClientAdapter>().InSingletonScope();
            Bind<ILdapClientAdapter>().To<LdapClientAdapter>().InSingletonScope();
            Bind<IEDocClientAdapter>().To<EDocClientAdapter>().InSingletonScope();
            Bind<IIdvConsumerAdapter>().To<IdvConsumerAdapter>().InSingletonScope();
            Bind<IBcPortalAdapter>().To<BcPortalAdapter>().InSingletonScope();
            Bind<IEdwPsarAdapter>().To<EdwPsarAdapter>().InSingletonScope();
            Bind<IFdwInquiryAdapter>().To<FdwInquiryAdapter>().InSingletonScope();
        }

        private void RegisterFakeAdapters()
        {
            Bind<ISsoLoginPortClientAdapter>().To<FakeSsoLoginPortClientAdapter>().InSingletonScope();
            Bind<ILdapClientAdapter>().To<FakeLdapClientAdapter>().InSingletonScope();
            Bind<IEDocClientAdapter>().To<FakeEDocClientAdapter>().InSingletonScope();
            Bind<IIdvConsumerAdapter>().To<FakeIdvConsumerAdapter>().InSingletonScope();
            Bind<IBcPortalAdapter>().To<FakeBcPortalAdapter>().InSingletonScope();
            Bind<IEdwPsarAdapter>().To<FakeEdwPsarAdapter>().InSingletonScope();
            Bind<IFdwInquiryAdapter>().To<FakeFdwInquiryAdapter>().InSingletonScope();
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

            //EDOC MTOM
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<EDocClientAdapter>()
                .WithConstructorArgument("cprKey", "service.eDocMtom.url");

            //BC PORTAL
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<BcPortalAdapter>()
                .WithConstructorArgument("cprKey", "service.bcPortal.url");

            //IDV CONSUMER
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<IdvConsumerAdapter>()
                .WithConstructorArgument("cprKey", "service.idvConsumer.url");

            //EDW PSAR
            Bind<IWcfEndpointAddressAdapter>().To<WcfEndpointAddressAdapter>()
                .WhenInjectedInto<IEdwPsarAdapter>()
                .WithConstructorArgument("cprKey", "service.edwPsar.url");
        }

        private void RegisterPermissions()
        {
            Bind<IRolePermissionAdapter>().To<BackOfficeRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<AgentRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<InsuredRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<MotorCarrierRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<OwnerCorporateRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<ViewAllRolePermissionAdapter>();
            Bind<IRolePermissionAdapter>().To<GaicEmployeeRolePermissionAdapter>();

        }
    }
}