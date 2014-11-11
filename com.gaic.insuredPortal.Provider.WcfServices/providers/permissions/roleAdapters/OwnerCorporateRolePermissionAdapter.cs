using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters
{
    public class OwnerCorporateRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.OwnerCorporate; }
        }

        public PermissionModel GetPermissionSet()
        {
            return new PermissionModel
            {
                CanViewSubPolicy = true,
                CanViewPolicyHistory = true,
                CanCustomizeReports = true,
                CanSubmitClaims = true,
                CanViewAgentSubPolicy = true,
                CanViewBillHistory = true,
                CanViewAllAgentPolicy = true,
                CanPayAgencyBill = true,
                CanPayDirectBill = true,
                CanViewCannedReports = true,
                CanViewClaimSummary = true,
                CanViewCurrentBill = true,
                CanViewDocuments = true,
                CanViewMasterPolicy = true,
            };
        }
    }
}