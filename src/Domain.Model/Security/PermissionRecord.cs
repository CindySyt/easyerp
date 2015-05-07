﻿namespace Domain.Model.Security
{
    using Domain.Model.Users;
    using Infrastructure.Domain.Model;
    using System.Collections.Generic;

    public class PermissionRecord : BaseEntity, IAggregateRoot
    {
        private ICollection<UserRole> userRoles;

        public string Name { get; set; }

        public string SystemName { get; set; }

        public string Category { get; set; }

        public virtual ICollection<UserRole> CustomerRoles
        {
            get { return userRoles ?? (userRoles = new List<UserRole>()); }
            protected set { userRoles = value; }
        }
    }
}