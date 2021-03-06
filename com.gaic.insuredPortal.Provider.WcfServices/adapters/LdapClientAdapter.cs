﻿using System;
using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.LdapService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class LdapClientAdapter : ILdapClientAdapter, IDisposable
    {
        private readonly LdapServiceClient _ldapServiceClient;

        public LdapClientAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _ldapServiceClient = new LdapServiceClient(bindingAdapter.Binding, endpointAddressAdapter.EndpointAddress);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public UserModel GetPerson(string userId, string token)
        {
            var request = new personDto {vid = userId};

            SecureSoapContext.AttachSecurityToken(_ldapServiceClient.InnerChannel, token);
            personDto response = _ldapServiceClient.getPerson(request);

            UserModel userModel = MapPersonToUser(response);
            userModel.Token = token;
            return userModel;
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_ldapServiceClient.InnerChannel, token);
            long returnValue = _ldapServiceClient.ping();

            return returnValue > 0;
        }

        public List<UserModel> GetPersonsInRole(string roleNameWithPrefix, string token)
        {
            var request = new groupDto {name = roleNameWithPrefix};

            SecureSoapContext.AttachSecurityToken(_ldapServiceClient.InnerChannel, token);
            personDto[] response = _ldapServiceClient.getGroupMembers(request, false);

            var users = new List<UserModel>();
            if (Utils.HasRows<personDto>(response)) users.AddRange(response.Select(MapPersonToUser));
            return users;
        }

        public List<string> GetGroupsForPerson(string userId, string token)
        {
            var request = new personDto {vid = userId};

            SecureSoapContext.AttachSecurityToken(_ldapServiceClient.InnerChannel, token);
            groupDto[] response = _ldapServiceClient.getGroupMembership(request, false);

            var roles = new List<string>();
            if (Utils.HasRows<groupDto>(response)) roles.AddRange(response.Select(groupDto => groupDto.name));

            return roles.OrderBy(x => x).ToList();
        }

        private static UserModel MapPersonToUser(personDto personDto)
        {
            List<RoleItemModel> roles = RoleItemModel.MapToRoles(GenerateGroupList(personDto.memberOf));
            var user = new UserModel
            {
                UserId = personDto.vid,
                UniversalId = personDto.hid,
                BusinessUnit = personDto.businessUnit,
                FirstName = personDto.firstName,
                LastName = personDto.lastName,
                CommonName = personDto.commonName,
                PhoneNumber = personDto.phone,
                Email = personDto.email,
                Roles = roles,
                Department = personDto.department,
                Division = personDto.division,
            };

            return user;
        }


        private static List<string> GenerateGroupList(groupDto[] wsGroupList)
        {
            if (wsGroupList == null) return new List<string>(0);
            var retList = new List<string>(wsGroupList.Length);
            retList.AddRange(wsGroupList.Select(@group => @group.name));
            return retList;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _ldapServiceClient.Close();
            }
            // free native resources
        }
    }
}