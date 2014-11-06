using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using Ninject.Modules;

namespace com.gaic.insuredPortal.Provider.HttpContext
{
    public class HttpContextBootstrap : NinjectModule
    {
        public override void Load()
        {
            Bind<IHttpContextStrategyProvider>().To<HttpContextStrategyProvider>();
            Bind<IHttpContextAdapter>().To<SiteMinderUserHttpContextAdapter>();
            Bind<IHttpContextAdapter>().To<LocalUserHttpContextAdapter>();
        }
    }
}