using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.enums;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public class MotorCarrierRoleFakeEDocClientAdapter : IRoleFakeEDocClientAdapter
    {
        private readonly Dictionary<BusinessUnitEnum, IBuMotorCarrierFakeEDocClientAdapter> _buRoleFakeEdocAdapters;

        public MotorCarrierRoleFakeEDocClientAdapter(IEnumerable<IBuMotorCarrierFakeEDocClientAdapter> buRoleFakeEdocAdapters)
        {
            _buRoleFakeEdocAdapters = buRoleFakeEdocAdapters.ToDictionary(x => x.BusinessUnitEnum);
        }

        public RoleItemModel Role
        {
            get { return RoleItemModel.MotorCarrier; }
        }

        public List<PolicyModel> GetPolicies(UserModel user)
        {
            return _buRoleFakeEdocAdapters[user.BusinessUnit.GetEnum<BusinessUnitEnum>()].GetPolicies();
        }
    }
}