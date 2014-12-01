using System.Collections.Generic;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class SearchModel
    {
        public string InsuredName { get; set; }
        public AddressModel InsuredAddress { get; set; }
        public string Symbol { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyStatus { get; set; }
    }
}