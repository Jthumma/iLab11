namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class PermissionModel
    {
        public string Name { get; set; }

        public RoleItemModel Role { get; set; }

        public bool ShowNotifications { get; set; }
        public bool CanViewMasterPolicy { get; set; }
        public bool CanViewSubPolicy { get; set; }
        public bool CanViewAgentSubPolicy { get; set; }
        public bool CanViewAllAgentPolicy { get; set; }
        public bool CanViewPolicyHistory { get; set; }
        //public bool CanViewAgentInfo { get; set; }
        //public bool CanViewAdjusterInfo { get; set; }
        public bool CanViewCannedReports { get; set; }
        public bool CanCustomizeReports { get; set; }
        public bool CanSubmitClaims { get; set; }
        public bool CanViewClaimSummary { get; set; }
        public bool CanViewDocuments { get; set; }
        public bool CanViewCurrentBill { get; set; }
        public bool CanViewBillHistory { get; set; }
        public bool CanPayDirectBill { get; set; }
        public bool CanPayAgencyBill { get; set; }

    }
}