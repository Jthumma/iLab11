using iLab11ProtoNg.Core.Domain.interfaces.provider;
using Ninject.Modules;

namespace iLab11ProtoNg.Provider.HttpContext
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