using com.gaic.insuredPortal.Core.Domain.interfaces.service;
using log4net;
using Ninject.Modules;

namespace com.gaic.insuredPortal.DomainServices
{
    public class DomainServicesBootstrap : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>()
                .ToMethod(context => LogManager.GetLogger(context.Request.Target.Member.ReflectedType))
                .InSingletonScope();

            Bind<IAuthorizationService>().To<AuthorizationService>();
            Bind<IPolicyService>().To<PolicyService>();
            Bind<IAgentService>().To<AgentService>();
            Bind<IClaimsService>().To<ClaimsService>();
        }
    }
}