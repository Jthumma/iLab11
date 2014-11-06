using System.Collections.Generic;
using iLab11ProtoNg.Core.Domain;
using iLab11ProtoNg.Core.Domain.domain;
using iLab11ProtoNg.Core.Domain.interfaces.provider;
using iLab11ProtoNg.Provider.WcfServices.adapters.interfaces;

namespace iLab11ProtoNg.Provider.WcfServices.providers
{
    public class WcfLdapProvider : ILdapProvider
    {
        private readonly ILdapClientAdapter _ldapClientAdapter;

        public WcfLdapProvider(ILdapClientAdapter ldapClientAdapter)
        {
            _ldapClientAdapter = ldapClientAdapter;
        }

        public virtual User GetPerson(string userId, string token)
        {
            Ensure.ArgumentNotNullOrEmpty(userId, "UserId");
            Ensure.ArgumentNotNullOrEmpty(token, "Token");

            return _ldapClientAdapter.GetPerson(userId, token);
        }

        public List<User> GetPersonsInRole(string roleNameWithPrefix, string token)
        {
            Ensure.ArgumentNotNullOrEmpty(roleNameWithPrefix, "RoleName");
            Ensure.ArgumentNotNullOrEmpty(token, "Token");

            return _ldapClientAdapter.GetPersonsInRole(roleNameWithPrefix, token);
        }

        public List<string> GetGroupsForPerson(string userId, string token)
        {
            Ensure.ArgumentNotNullOrEmpty(userId, "UserId");
            Ensure.ArgumentNotNullOrEmpty(token, "Token");

            return _ldapClientAdapter.GetGroupsForPerson(userId, token);
        }

        public bool Ping(string token)
        {
            return _ldapClientAdapter.Ping(token);
        }
    }
}