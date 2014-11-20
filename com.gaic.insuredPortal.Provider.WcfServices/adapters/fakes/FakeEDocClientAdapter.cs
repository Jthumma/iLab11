using System.Collections.Generic;
using System.Linq;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes.eDoc;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeEDocClientAdapter : IEDocClientAdapter
    {
        private readonly Dictionary<RoleItemModel, IRoleFakeEDocClientAdapter> _roleFakeEDocClientAdapters;

        public FakeEDocClientAdapter(IEnumerable<IRoleFakeEDocClientAdapter> rolePermissionAdapters)
        {
            _roleFakeEDocClientAdapters = rolePermissionAdapters.ToDictionary(x => x.Role);
        }

        public bool Ping(string token)
        {
            return true;
        }

        public List<PolicyModel> GetPolicies(string policyNumber, UserModel user)
        {
            return _roleFakeEDocClientAdapters[user.Roles.First()].GetPolicies(user);
        }
    }
}