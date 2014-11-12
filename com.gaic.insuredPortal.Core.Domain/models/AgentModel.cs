﻿using System.Collections.Generic;

namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class AgentModel
    {
        public string Name { get; set; }
        public string AgencyName { get; set; }
        public AddressModel Address { get; set; }
        public string AgentCode { get; set; }
        public ContactModel Contact { get; set; }
    }
}