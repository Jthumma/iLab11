using Ninject.Modules;

namespace iLab11ProtoNg.Provider.Cpr
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