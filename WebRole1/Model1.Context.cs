﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRole1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VolunteerNetworkEntities : DbContext
    {
        public VolunteerNetworkEntities()
            : base("name=VolunteerNetworkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<uk_towns> uk_towns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ShopperAddress> ShopperAddresses { get; set; }
        public virtual DbSet<SupportTask> SupportTasks { get; set; }
        public virtual DbSet<AuditTable> AuditTables { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<SearchArea> SearchAreas { get; set; }
        public virtual DbSet<VolunteerAddress> VolunteerAddresses { get; set; }
    }
}
