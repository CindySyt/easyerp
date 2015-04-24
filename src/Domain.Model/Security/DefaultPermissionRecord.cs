﻿namespace Domain.Model.Security
{
    using System.Collections.Generic;

    public class DefaultPermissionRecord
    {
        public DefaultPermissionRecord()
        {
            PermissionRecords = new List<PermissionRecord>();
        }

        public string UserRoleSystemName { get; set; }
        public IEnumerable<PermissionRecord> PermissionRecords { get; set; }
    }
}