using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions.roleAdapters
{
    public class NoAccessRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.NoAccess; }
        }

        public PermissionModel GetPermissionSet()
        {
            return new PermissionModel();
        }
    }
}