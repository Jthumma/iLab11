using System.Collections.Generic;
using System.Linq;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class RoleItemModel : ListItemModel
    {
        public static readonly string RolePrefix = "Static.Global.WF.InsuredPortal.Role.";

        public static readonly RoleItemModel Agent = new RoleItemModel("Agent", RolePrefix + "Agent");
        public static readonly RoleItemModel Insured = new RoleItemModel("Insured", RolePrefix + "Insured");
        public static readonly RoleItemModel OwnerCorporate = new RoleItemModel("OwnerCorporate", RolePrefix + "OwnerCorporate");
        public static readonly RoleItemModel TeamIndy = new RoleItemModel("TeamIndy", RolePrefix + "TeamIndy");
        public static readonly RoleItemModel MotorCarrier = new RoleItemModel("MotorCarrier", RolePrefix + "MotorCarrier");
        public static readonly RoleItemModel GaicEmployee = new RoleItemModel("GaicEmployee", RolePrefix + "GaicEmployee");
        public static readonly RoleItemModel BackOffice = new RoleItemModel("BackOffice", RolePrefix + "BackOffice");
        public static readonly RoleItemModel ViewAll = new RoleItemModel("ViewAll", RolePrefix + "View");

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