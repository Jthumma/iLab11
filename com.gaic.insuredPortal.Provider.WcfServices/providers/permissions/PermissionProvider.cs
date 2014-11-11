using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters;

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

            aggregatePermissionSet.CanViewAgentSubPolicy = CanViewAgentSubPolicy(permissionSetList);
            aggregatePermissionSet.CanViewAllAgentPolicy = CanViewAllAgentPolicy(permissionSetList);
            aggregatePermissionSet.CanViewCannedReports = CanViewCannedReports(permissionSetList);
            aggregatePermissionSet.CanCustomizeReports = CanCustomizeReports(permissionSetList);
            aggregatePermissionSet.CanViewPolicyHistory = CanViewPolicyHistory(permissionSetList);
            aggregatePermissionSet.CanViewMasterPolicy = CanViewMasterPolicy(permissionSetList);
            aggregatePermissionSet.CanSubmitClaims = CanSubmitClaims(permissionSetList);
            aggregatePermissionSet.CanViewClaimSummary = CanViewClaimSummary(permissionSetList);
            aggregatePermissionSet.CanViewDocuments = CanViewDocuments(permissionSetList);
            aggregatePermissionSet.CanViewSubPolicy = CanViewSubPolicy(permissionSetList);
            aggregatePermissionSet.CanViewCurrentBill = CanViewCurrentBill(permissionSetList);
            aggregatePermissionSet.CanViewBillHistory = CanViewBillHistory(permissionSetList);
            aggregatePermissionSet.CanPayDirectBill = CanPayDirectBill(permissionSetList);
            aggregatePermissionSet.CanPayAgencyBill = CanPayAgencyBill(permissionSetList);
            aggregatePermissionSet.ShowNotifications = ShowNotifications(permissionSetList);

            return aggregatePermissionSet;
        }


        private List<PermissionModel> GetPermissionSetsForRoles(IEnumerable<RoleItemModel> roles)
        {
            return roles.Select(GetPermissionSetForRole).ToList();
        }

        private PermissionModel GetPermissionSetForRole(RoleItemModel role)
        {
            Ensure.ArgumentNotNull(role, "Role");

            // Permissions can be hardwired or can be retrieved from the database
            //return _permissionRepository.GetAll().Single(x => x.Role.Code == role.Code);
            return _rolePermissionAdapters[role].GetPermissionSet();
        }

        private static bool CanViewMasterPolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewMasterPolicy);
        }

        private static bool CanViewSubPolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewSubPolicy);
        }

        private static bool CanViewAgentSubPolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewAgentSubPolicy);
        }

        private static bool CanViewAllAgentPolicy(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewAllAgentPolicy);
        }

        private static bool CanViewPolicyHistory(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewPolicyHistory);
        }

        private static bool CanViewCannedReports(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewCannedReports);
        }

        private static bool CanCustomizeReports(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanCustomizeReports);
        }

        private static bool CanSubmitClaims(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanSubmitClaims);
        }

        private static bool CanViewClaimSummary(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewClaimSummary);
        }

        private static bool CanViewDocuments(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewDocuments);
        }

        private static bool CanViewCurrentBill(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewCurrentBill);
        }

        private static bool CanViewBillHistory(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanViewBillHistory);
        }

        private static bool CanPayDirectBill(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanPayDirectBill);
        }

        private static bool CanPayAgencyBill(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.CanPayAgencyBill);
        }

        private static bool ShowNotifications(IEnumerable<PermissionModel> permissionSets)
        {
            return permissionSets.Any(permissionSet => permissionSet.ShowNotifications);
        }
    }
}