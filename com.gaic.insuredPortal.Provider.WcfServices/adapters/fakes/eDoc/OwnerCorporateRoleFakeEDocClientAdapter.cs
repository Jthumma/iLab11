using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.enums;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class OwnerCorporateRoleFakeEDocClientAdapter : IRoleFakeEDocClientAdapter
    {
        private readonly Dictionary<BusinessUnitEnum, IBuOwnerCorporateFakeEDocClientAdapter> _buRoleFakeEdocAdapters;

        public OwnerCorporateRoleFakeEDocClientAdapter(IEnumerable<IBuOwnerCorporateFakeEDocClientAdapter> buRoleFakeEdocAdapters)
        {
            _buRoleFakeEdocAdapters = buRoleFakeEdocAdapters.ToDictionary(x => x.BusinessUnitEnum);
        }

        public RoleItemModel Role
        {
            get { return RoleItemModel.OwnerCorporate; }
        }

        public List<PolicyModel> GetPolicies(UserModel user)
        {
            return _buRoleFakeEdocAdapters[user.BusinessUnit.GetEnum<BusinessUnitEnum>()].GetPolicies();
        }
    }
}