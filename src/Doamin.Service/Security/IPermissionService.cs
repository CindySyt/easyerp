﻿namespace Doamin.Service.Security
{
    using System.Collections.Generic;
    using Domain.Model.Security;
    using Domain.Model.Users;

    public interface IPermissionService
    {
        void DeletePermissionRecord(PermissionRecord permission);
        PermissionRecord GetPermissionRecordById(int permissionId);
        PermissionRecord GetPermissionRecordBySystemName(string systemName);
        IList<PermissionRecord> GetAllPermissionRecords();
        void InstallPermissions(IPermissionProvider permissionProvider);
        void InsertPermissionRecord(PermissionRecord permission);
        void UpdatePermissionRecord(PermissionRecord permission);
        bool Authorize(PermissionRecord permission);
        bool Authorize(PermissionRecord permission, User user);
        bool Authorize(string permissionRecordSystemName);
        bool Authorize(string permissionRecordSystemName, User user);
    }
}