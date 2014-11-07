using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions
{
    public class PolicyViewRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.PolicyView; }
        }

        public PermissionModel GetPermissionSet()
        {
            return new PermissionModel {CanViewPolicy = true};
        }
    }
}