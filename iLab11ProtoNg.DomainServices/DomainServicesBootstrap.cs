using iLab11ProtoNg.Core.Domain.interfaces.service;
using log4net;
using Ninject.Modules;

namespace iLab11ProtoNg.DomainServices
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
