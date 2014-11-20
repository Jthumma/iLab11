using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class GaicEmployeeRoleFakeEDocClientAdapter : IRoleFakeEDocClientAdapter
    {
        private readonly Dictionary<BusinessUnits, IBuGaicEmployeeFakeEDocClientAdapter> _buRoleFakeEdocAdapters;

        public GaicEmployeeRoleFakeEDocClientAdapter(IEnumerable<IBuGaicEmployeeFakeEDocClientAdapter> buRoleFakeEdocAdapters)
        {
            _buRoleFakeEdocAdapters = buRoleFakeEdocAdapters.ToDictionary(x => x.BusinessUnit);
        }

        public RoleItemModel Role
        {
            get { return RoleItemModel.GaicEmployee; }
        }

        public List<PolicyModel> GetPolicies(UserModel user)
        {
            return _buRoleFakeEdocAdapters[user.BusinessUnit.GetEnum<BusinessUnits>()].GetPolicies();
        }
    }
}