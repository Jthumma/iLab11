using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.eDocMtomService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class EDocClientAdapter : IEDocClientAdapter, IDisposable
    {
        private readonly ECMServiceSoapClient _ecmServiceSoapClient;

        public EDocClientAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _ecmServiceSoapClient = new ECMServiceSoapClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_ecmServiceSoapClient.InnerChannel, token);
            var version = _ecmServiceSoapClient.GetVersion();
            return !String.IsNullOrEmpty(version);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<PolicyModel> GetPolicies(string policyNumber, string token)
        {
            SecureSoapContext.AttachSecurityToken(_ecmServiceSoapClient.InnerChannel, token);
            Document[] documents = _ecmServiceSoapClient.SearchPolicyDocuments(String.Format("PolicyNumber='{0}'", policyNumber));

            return Mapper.Map<List<Document>, List<PolicyModel>>(documents.ToList());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _ecmServiceSoapClient.Close();
            }
            // free native resources
        }
    }
}