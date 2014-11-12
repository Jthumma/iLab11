using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters
{
    public class InsuredRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.Insured; }
        }

        public PermissionModel GetPermissionSet()
        {
            return new PermissionModel
            {
                CanViewSubPolicy = true,
                CanViewPolicyHistory = false,
                CanCustomizeReports = false,
                CanSubmitClaims = true,
                CanViewAgentSubPolicy = false,
                CanViewBillHistory = true,
                CanViewAllAgentPolicy = false,
                CanPayAgencyBill = false,
                CanPayDirectBill = true,
                CanViewCannedReports = true,
                CanViewClaimSummary = true,
                CanViewCurrentBill = true,
                CanViewDocuments = false,
                CanViewMasterPolicy = false,
                ShowNotifications = true
            };
        }
    }
}