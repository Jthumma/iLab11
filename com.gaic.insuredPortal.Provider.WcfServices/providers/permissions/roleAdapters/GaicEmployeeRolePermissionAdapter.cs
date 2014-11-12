using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters
{
    public class GaicEmployeeRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.GaicEmployee; }
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
                CanPayAgencyBill = false,
                CanPayDirectBill = false,
                CanViewCannedReports = true,
                CanViewClaimSummary = true,
                CanViewCurrentBill = true,
                CanViewDocuments = true,
                CanViewMasterPolicy = true,
            };
        }
    }
}