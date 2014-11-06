using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using Ninject.Modules;

namespace com.gaic.insuredPortal.Provider.Cpr
{
    public class CprBootstrap : NinjectModule
    {
        public override void Load()
        {
            Bind<ICprProviderAdapter>()
                .To<CprProviderAdapter>()
                .InSingletonScope()
                .WithConstructorArgument("cprNamespace", "com.gaic.insuredPortal");

            Bind<ICprProvider>().To<CprProvider>().InSingletonScope();
        }
    }
}