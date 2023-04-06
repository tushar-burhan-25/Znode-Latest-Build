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
    
    public partial class ZnodeSearchCatalogRule : ZnodeEntityBaseModel
    {
        public ZnodeSearchCatalogRule()
        {
            this.ZnodeSearchItemRules = new HashSet<ZnodeSearchItemRule>();
            this.ZnodeSearchTriggerRules = new HashSet<ZnodeSearchTriggerRule>();
        }
    
        public int SearchCatalogRuleId { get; set; }
        public int PublishCatalogId { get; set; }
        public string RuleName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool IsTriggerForAll { get; set; }
        public bool IsItemForAll { get; set; }
        public bool IsGlobalRule { get; set; }
        public bool IsPause { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeSearchItemRule> ZnodeSearchItemRules { get; set; }
        public virtual ICollection<ZnodeSearchTriggerRule> ZnodeSearchTriggerRules { get; set; }
    }
}
