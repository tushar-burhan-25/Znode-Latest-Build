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
    
    public partial class ZnodeSearchFeature : ZnodeEntityBaseModel
    {
        public ZnodeSearchFeature()
        {
            this.ZnodeSearchFeature1 = new HashSet<ZnodeSearchFeature>();
            this.ZnodeSearchProfileFeatureMappings = new HashSet<ZnodeSearchProfileFeatureMapping>();
            this.ZnodeSearchQueryTypeFeatures = new HashSet<ZnodeSearchQueryTypeFeature>();
        }
    
        public int SearchFeatureId { get; set; }
        public Nullable<int> ParentSearchFeatureId { get; set; }
        public string FeatureCode { get; set; }
        public string FeatureName { get; set; }
        public bool IsAdvanceFeature { get; set; }
        public string ControlType { get; set; }
        public string HelpDescription { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeSearchFeature> ZnodeSearchFeature1 { get; set; }
        public virtual ZnodeSearchFeature ZnodeSearchFeature2 { get; set; }
        public virtual ICollection<ZnodeSearchProfileFeatureMapping> ZnodeSearchProfileFeatureMappings { get; set; }
        public virtual ICollection<ZnodeSearchQueryTypeFeature> ZnodeSearchQueryTypeFeatures { get; set; }
    }
}
