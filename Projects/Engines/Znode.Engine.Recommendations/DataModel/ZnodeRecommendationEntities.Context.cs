﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Engine.Recommendations.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Znode_Recommendation_Entities : DbContext
    {
        public Znode_Recommendation_Entities()
            : base("name=Znode_Recommendation_Entities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ZnodeRecommendationBaseProduct> ZnodeRecommendationBaseProducts { get; set; }
        public virtual DbSet<ZnodeRecommendationProcessingLog> ZnodeRecommendationProcessingLogs { get; set; }
        public virtual DbSet<ZnodeRecommendedProduct> ZnodeRecommendedProducts { get; set; }
    }
}
