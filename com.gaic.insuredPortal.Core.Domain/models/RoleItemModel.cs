using System.Collections.Generic;
using System.Linq;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class RoleItemModel : ListItemModel
    {
        public static readonly string RolePrefix = "Static.Global.WF.FISDT.Role.";

        public static readonly RoleItemModel PolicyAdmin = new RoleItemModel("PolicyAdmin", RolePrefix + "PolicyAdmin");
        public static readonly RoleItemModel PolicyView = new RoleItemModel("PolicyView", RolePrefix + "PolicyView");
        public static readonly RoleItemModel EarningsAdmin = new RoleItemModel("EarningsAdmin", RolePrefix + "EarningsAdmin");
        public static readonly RoleItemModel FinancialAdmin = new RoleItemModel("FinancialAdmin", RolePrefix + "FinancialAdmin");
        public static readonly RoleItemModel ProducerAdmin = new RoleItemModel("ProducerAdmin", RolePrefix + "ProducerAdmin");
        public static readonly RoleItemModel ITAnalyst = new RoleItemModel("ITAnalyst", RolePrefix + "ITAnalyst");
        public static readonly RoleItemModel ViewAll = new RoleItemModel("ViewAll", RolePrefix + "View");
        public static readonly RoleItemModel PolicyNumberAdmin = new RoleItemModel("PolicyNumberAdmin", RolePrefix + "PolNumMngnt");

        public RoleItemModel(string code, string description) : base(code, description)
        {
            if (Items == null) Items = new List<ListItemModel>();
            Items.Add(this);
        }

        public static List<ListItemModel> Items { get; set; }

        public static List<RoleItemModel> MapToRoles(List<string> ldapGroupList)
        {
            if (!Utils.HasRows<string>(ldapGroupList)) return null;

            List<RoleItemModel> roles = (from ldapGroupStr in ldapGroupList
                select MatchLdapGroupToRole(ldapGroupStr)
                into role
                where role != null
                select role).ToList();

            return roles;
        }

        private static RoleItemModel MatchLdapGroupToRole(string ldapGroupStr)
        {
            var role =
                Items.FirstOrDefault(c => c.Description.ToLower().Trim() == ldapGroupStr.ToLower().Trim()) as
                    RoleItemModel;
            return role;
        }
    }
}