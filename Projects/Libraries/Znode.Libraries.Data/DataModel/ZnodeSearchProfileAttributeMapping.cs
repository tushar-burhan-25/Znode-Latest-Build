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
    
    public partial class ZnodeSearchProfileAttributeMapping : ZnodeEntityBaseModel
    {
        public int SearchProfileAttributeMappingId { get; set; }
        public int SearchProfileId { get; set; }
        public string AttributeCode { get; set; }
        public bool IsFacets { get; set; }
        public bool IsUseInSearch { get; set; }
        public Nullable<int> BoostValue { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsNgramEnabled { get; set; }
    
        public virtual ZnodeSearchProfile ZnodeSearchProfile { get; set; }
    }
}
