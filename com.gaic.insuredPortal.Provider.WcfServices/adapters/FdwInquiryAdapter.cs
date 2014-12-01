using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.FdwInquiryService;
using Utility.WCFSiteMinderSecurity;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters
{
    public class FdwInquiryAdapter : IFdwInquiryAdapter, IDisposable
    {
        private readonly FdwInquiryServiceClient _fdwClient;

        public FdwInquiryAdapter(IWcfHttpBindingAdapter bindingAdapter,
            IWcfEndpointAddressAdapter endpointAddressAdapter)
        {
            _fdwClient = new FdwInquiryServiceClient(bindingAdapter.Binding,
                endpointAddressAdapter.EndpointAddress);
            
        }

        public bool Ping(string token)
        {
            SecureSoapContext.AttachSecurityToken(_fdwClient.InnerChannel, token);
            var value = _fdwClient.ping();
            return value > 0;
        }

        public List<PolicyModel> SearchFdw(SearchModel searchCriteria, string token)
        {
            serviceSearchCriteria criteria = Mapper.Map<SearchModel, serviceSearchCriteria>(searchCriteria);
            SecureSoapContext.AttachSecurityToken(_fdwClient.InnerChannel, token);
            var searchResults = _fdwClient.searchFDW(criteria);
            return searchResults.resultCount == 0 
                ? null
                : Mapper.Map<List<policyClaimLookupFDW>, List<PolicyModel>>(searchResults.results.OfType<policyClaimLookupFDW>().ToList());
        }

        //public bool searchRenewals(string token)
        //{
        //    SecureSoapContext.AttachSecurityToken(_fdwClient.InnerChannel, token);
        //    var value = _fdwClient.searchRenewals();
        //    return value > 0;
        //}

        //public bool searchCustomers(string token)
        //{
        //    SecureSoapContext.AttachSecurityToken(_fdwClient.InnerChannel, token);
        //    var value = _fdwClient.searchCustomers();
        //    return value > 0;
        //}

        //public bool retrieveECFInfo(string token)
        //{
        //    SecureSoapContext.AttachSecurityToken(_fdwClient.InnerChannel, token);
        //    var value = _fdwClient.retrieveECFInfo();
        //    return value > 0;
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                _fdwClient.Close();
            }
            // free native resources
        }
    }
}