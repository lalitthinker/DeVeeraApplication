﻿using CRM.Core.Domain.Common;
using CRM.Core.Domain.Users;
using CRM.Core.Domain.Directory;

using CRM.Core.Domain.Security;
using CRM.Data.Mapping.Users;
using CRM.Data.Mapping.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using CRM.Core.Domain;
using CRM.Core.Domain.VideoModules;

namespace CRM.Data
{
    public class dbContextCRM: DbContext
    {
        public dbContextCRM(DbContextOptions<dbContextCRM> options)
           : base(options)
        {
            Database.SetCommandTimeout(1500000);
        }

      

        
        public DbSet<Country> Country { get; set; }
        public DbSet<StateProvince> StateProvince { get; set; }
        public DbSet<Address> Address { get; set; }

 
        //User
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserPassword> UserPassword { get; set; }

        //Security
        public DbSet<PermissionRecord> PermissionRecord { get; set; }

        //Video
        public DbSet<Video> Videos { get; set; }
        public DbSet<Modules> VideoModules { get; set; }

        //Quote
        public DbSet<WeeklyUpdate> WeeklyUpdates { get; set; }
        public DbSet<DashboardQuote> DashboardQuote { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            // base.OnModelCreating(modelBuilder);
         

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
       
            //User
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());

            //security
            modelBuilder.ApplyConfiguration(new PermissionRecordMap());

           
            base.OnModelCreating(modelBuilder);
        }
    }
}
