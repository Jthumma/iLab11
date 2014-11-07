﻿using com.gaic.insuredPortal.Core.Domain.models;

namespace com.gaic.insuredPortal.Provider.WcfServices.providers.permissions
{
    public class PolicyAdminRolePermissionAdapter : IRolePermissionAdapter
    {
        public RoleItemModel Role
        {
            get { return RoleItemModel.PolicyAdmin; }
        }

        public PermissionModel GetPermissionSet()
        {
            return new PermissionModel {CanViewPolicy = true, CanSavePolicy = true};
        }
    }
}