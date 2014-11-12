using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters
{
    public class AgentRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.Agent; }
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
                CanViewAllAgentPolicy = false,
                CanPayAgencyBill = false,
                CanPayDirectBill = false,
                CanViewCannedReports = true,
                CanViewClaimSummary = true,
                CanViewCurrentBill = true,
                CanViewDocuments = false,
                CanViewMasterPolicy = false,
            };
        }
    }
}