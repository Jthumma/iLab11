using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions
{
    public class PermissionProvider : IPermissionProvider
    {
        private readonly Dictionary<RoleItemModel, IRolePermissionAdapter> _rolePermissionAdapters;

        public PermissionProvider(IEnumerable<IRolePermissionAdapter> rolePermissionAdapters)
        {
            _rolePermissionAdapters = rolePermissionAdapters.ToDictionary(x => x.Role);
        }

        public PermissionModel GetUserPermissionSet(List<RoleItemModel> roles)
        {
            var aggregatePermissionSet = new PermissionModel();
            if (!Utils.HasRows<RoleItemModel>(roles)) return aggregatePermissionSet;

            List<PermissionModel> permissionSetList = GetPermissionSetsForRoles(roles);

            //aggregatePermissionSet.CanActivatePolicy = CanActivatePolicy(permissionSetList);
            //aggregatePermissionSet.CanGenerateEarnings = CanGenerateEarnings(permissionSetList);
            //aggregatePermissionSet.CanGeneratePolicyNumbers = CanGeneratePolicyNumbers(permissionSetList);
            //aggregatePermissionSet.CanSaveFinancial = CanSaveFinancial(permissionSetList);
            aggregatePermissionSet.CanSavePolicy = CanSavePolicy(permissionSetList);
            //aggregatePermissionSet.CanSaveProducerDefaults = CanSaveProducerDefaults(permissionSetList);
            //aggregatePermissionSet.CanViewEarnings = CanViewEarnings(permissionSetList);
            //aggregatePermissionSet.CanViewFinancial = CanViewFinancial(permissionSetList);
            aggregatePermissionSet.CanViewPolicy = CanViewPolicy(permissionSetList);
            //aggregatePermissionSet.CanViewProducerDefaults = CanViewProducerDefaults(permissionSetList);
            //aggregatePermissionSet.CanViewPolicyNumbers = CanViewPolicyNumbers(permissionSetList);
            //aggregatePermissionSet.CanViewAllPolicyTabs = CanViewAllPolicyTabs(permissionSetList);

            return aggregatePermissionSet;
        }


        private List<PermissionModel> GetPermissionSetsForRoles(IEnumerable<RoleItemModel> roles)
        {
            return roles.Select(GetPermissionSetForRole).ToList();
        }

        private PermissionModel GetPermissionSetForRole(RoleItemModel role)
        {
            Ensure.ArgumentNotNull(role, "Role");
            //return null;
            //TODO return _permissionRepository.GetAll().Single(x => x.Role.Code == role.Code);
            return _rolePermissionAdapters[role].GetPermissionSet();
        }

        private static bool CanSavePolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanSavePolicy);
        }

        private static bool CanViewPolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewPolicy);
        }
    }
}