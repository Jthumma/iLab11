using Ninject.Modules;

namespace iLab11ProtoNg.DomainServices
{
    public class DomainServicesBootstrap : NinjectModule
    {
        public override void Load()
        {
            Bind<IPolicyService>().To<PolicyService>();
            Bind<IClaimsService>().To<ClaimsService>();
        }
    }
}
