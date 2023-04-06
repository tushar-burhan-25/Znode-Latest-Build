//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ZnodeSearchProfile : ZnodeEntityBaseModel
    {
        public ZnodeSearchProfile()
        {
            this.ZnodePortalSearchProfiles = new HashSet<ZnodePortalSearchProfile>();
            this.ZnodePublishCatalogSearchProfiles = new HashSet<ZnodePublishCatalogSearchProfile>();
            this.ZnodeSearchProfileAttributeMappings = new HashSet<ZnodeSearchProfileAttributeMapping>();
            this.ZnodeSearchProfileFeatureMappings = new HashSet<ZnodeSearchProfileFeatureMapping>();
            this.ZnodeSearchProfileFieldValueFactors = new HashSet<ZnodeSearchProfileFieldValueFactor>();
            this.ZnodeSearchProfileProductMappings = new HashSet<ZnodeSearchProfileProductMapping>();
            this.ZnodeSearchProfileTriggers = new HashSet<ZnodeSearchProfileTrigger>();
            this.ZnodeSearchActivities = new HashSet<ZnodeSearchActivity>();
        }
    
        public int SearchProfileId { get; set; }
        public string ProfileName { get; set; }
        public int SearchQueryTypeId { get; set; }
        public Nullable<int> SearchSubQueryTypeId { get; set; }
        public string Operator { get; set; }
        public bool IsDefault { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> PublishStateId { get; set; }
    
        public virtual ICollection<ZnodePortalSearchProfile> ZnodePortalSearchProfiles { get; set; }
        public virtual ICollection<ZnodePublishCatalogSearchProfile> ZnodePublishCatalogSearchProfiles { get; set; }
        public virtual ZnodeSearchQueryType ZnodeSearchQueryType { get; set; }
        public virtual ICollection<ZnodeSearchProfileAttributeMapping> ZnodeSearchProfileAttributeMappings { get; set; }
        public virtual ICollection<ZnodeSearchProfileFeatureMapping> ZnodeSearchProfileFeatureMappings { get; set; }
        public virtual ICollection<ZnodeSearchProfileFieldValueFactor> ZnodeSearchProfileFieldValueFactors { get; set; }
        public virtual ICollection<ZnodeSearchProfileProductMapping> ZnodeSearchProfileProductMappings { get; set; }
        public virtual ICollection<ZnodeSearchProfileTrigger> ZnodeSearchProfileTriggers { get; set; }
        public virtual ICollection<ZnodeSearchActivity> ZnodeSearchActivities { get; set; }
    }
}
