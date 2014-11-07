using System;
using System.Collections.Generic;
using System.Linq;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string UniversalId { get; set; }
        public DateTime LoginTime { get; set; }
        public string IpAddress { get; set; }
        public string BusinessUnit { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string Token { get; set; }
        public List<RoleItemModel> Roles { get; set; }
        public PermissionModel Permission { get; set; }

        public static List<string> ParseLdapGroups(string userGroups)
        {
            if (String.IsNullOrEmpty(userGroups)) return null;

            var retGroups = new List<string>();
            char[] delimiters = {'^'};
            string[] groups = userGroups.Split(delimiters);
            foreach (string s in groups)
            {
                char[] commas = {','};
                string[] commaSep = s.Split(commas);
                retGroups.AddRange(from s2 in commaSep where s2.StartsWith("cn=") select s2.Replace("cn=", ""));
            }
            return retGroups;
        }
    }
}