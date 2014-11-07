namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class PermissionModel
    {
        public string Name { get; set; }

        public RoleItemModel Role { get; set; }

        public bool CanSavePolicy { get; set; }
        public bool CanViewPolicy { get; set; }

    }
}