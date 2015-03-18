﻿namespace Infrastructure.Domain.EntityFramework
{
    using Infrastructure.Domain.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection;

    public class EntityFrameworkDbContext : DbContext, IEntityFrameworkDbContext
    {
        public EntityFrameworkDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class, IAggregateRoot
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                                          .Where(type => !String.IsNullOrEmpty(type.Namespace))
                                          .Where(
                                              type => type.BaseType != null && type.BaseType.IsGenericType &&
                                                      type.BaseType.GetGenericTypeDefinition() ==
                                                      typeof(ISetupConfiguration));
            foreach (var configurationInstance in typesToRegister.Select(Activator.CreateInstance))
            {
                modelBuilder.Configurations.Add((dynamic)configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}