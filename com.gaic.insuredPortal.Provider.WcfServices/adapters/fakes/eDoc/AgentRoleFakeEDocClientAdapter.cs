using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class AgentRoleFakeEDocClientAdapter : IRoleFakeEDocClientAdapter
    {
        private readonly Dictionary<BusinessUnits, IBuAgentFakeEDocClientAdapter> _buRoleFakeEdocAdapters;

        public AgentRoleFakeEDocClientAdapter(IEnumerable<IBuAgentFakeEDocClientAdapter> buRoleFakeEdocAdapters)
        {
            _buRoleFakeEdocAdapters = buRoleFakeEdocAdapters.ToDictionary(x => x.BusinessUnit);
        }

        public RoleItemModel Role
        {
            get { return RoleItemModel.Agent; }
        }

        public List<PolicyModel> GetPolicies(UserModel user)
        {
            return _buRoleFakeEdocAdapters[user.BusinessUnit.GetEnum<BusinessUnits>()].GetPolicies();
        }
    }
}