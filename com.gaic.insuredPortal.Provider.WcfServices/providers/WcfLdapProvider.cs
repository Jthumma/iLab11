using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.interfaces.provider;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers
{
    public class WcfLdapProvider : ILdapProvider
    {
        private readonly ILdapClientAdapter _ldapClientAdapter;

        public WcfLdapProvider(ILdapClientAdapter ldapClientAdapter)
        {
            _ldapClientAdapter = ldapClientAdapter;
        }

        public virtual UserModel GetPerson(string userId, string token)
        {
            Ensure.ArgumentNotNullOrEmpty(userId, "UserId");
            Ensure.ArgumentNotNullOrEmpty(token, "Token");

            return _ldapClientAdapter.GetPerson(userId, token);
        }

        public List<UserModel> GetPersonsInRole(string roleNameWithPrefix, string token)
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