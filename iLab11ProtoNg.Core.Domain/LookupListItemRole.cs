using System.Collections.Generic;
using System.Linq;

namespace iLab11ProtoNg.Core.Domain
{
    public class LookupListItemRole : LookupListItem
    {
        public LookupListItemRole(string code, string description) : base(code, description)
        {
            if (Items == null) Items = new List<LookupListItem>();
            Items.Add(this);
        }

        public static List<LookupListItem> Items { get; set; }

        public static List<LookupListItemRole> MapToRoles(List<string> ldapGroupList)
        {
            if (!Utils.HasRows<string>(ldapGroupList)) return null;

            List<LookupListItemRole> roles = (from ldapGroupStr in ldapGroupList
                select MatchLdapGroupToRole(ldapGroupStr)
                into role
                where role != null
                select role).ToList();

            return roles;
        }

        private static LookupListItemRole MatchLdapGroupToRole(string ldapGroupStr)
        {
            var role =
                Items.FirstOrDefault(c => c.Description.ToLower().Trim() == ldapGroupStr.ToLower().Trim()) as
                    LookupListItemRole;
            return role;
        }
    }
}