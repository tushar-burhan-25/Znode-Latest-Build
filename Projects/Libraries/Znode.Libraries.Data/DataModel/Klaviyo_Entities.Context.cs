﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Libraries.Data.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZnodeKlaviyoEntities : DbContext
    {
        public ZnodeKlaviyoEntities()
            : base("name=ZnodeKlaviyoEntities")
        {
        }
    
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZnodeEmailProvider>().ToTable("ZnodeEmailProvider");
            modelBuilder.Entity<ZnodePortalKlaviyoSetting>().ToTable("ZnodePortalKlaviyoSetting");
        }
        public virtual DbSet<ZnodeEmailProvider> ZnodeEmailProviders { get; set; }
        public virtual DbSet<ZnodePortalKlaviyoSetting> ZnodePortalKlaviyoSettings { get; set; }
    }
}
