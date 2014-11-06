using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.bindings.interfaces;
using com.gaic.insuredPortal.Provider.WcfServices.eDocMtomService;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<PolicyModel> GetPolicies()
        {
            Document[] documents = _ecmServiceSoapClient.SearchPolicyDocuments("");

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