using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc
{
    public interface IRoleFakeEDocClientAdapter
    {
        RoleItemModel Role { get; }
        List<PolicyModel> GetPolicies(UserModel user);
    }
}