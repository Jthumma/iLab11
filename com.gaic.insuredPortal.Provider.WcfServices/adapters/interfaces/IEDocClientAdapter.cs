﻿using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces
{
    public interface IEDocClientAdapter
    {
        List<PolicyModel> GetPolicies();
    }
}