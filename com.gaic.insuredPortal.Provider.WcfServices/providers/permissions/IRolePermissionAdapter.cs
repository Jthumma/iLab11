using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions
{
    public interface IRolePermissionAdapter
    {
        RoleItemModel Role { get; }
        PermissionModel GetPermissionSet();
    }
}