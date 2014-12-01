using System.Collections.Generic;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class ProducerModel
    {
        public string Name { get; set; }
        public string AgencyName { get; set; }
        public AddressModel Address { get; set; }
        public string Number { get; set; }
        public string ProfitCenter { get; set; }
        public ContactModel Contact { get; set; }
    }
}