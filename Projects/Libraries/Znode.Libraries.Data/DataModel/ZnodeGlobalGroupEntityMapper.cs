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
    
    public partial class ZnodeGlobalGroupEntityMapper : ZnodeEntityBaseModel
    {
        public int GlobalGroupEntityId { get; set; }
        public Nullable<int> GlobalAttributeGroupId { get; set; }
        public Nullable<int> GlobalEntityId { get; set; }
        public Nullable<int> AttributeGroupDisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeGlobalAttributeGroup ZnodeGlobalAttributeGroup { get; set; }
        public virtual ZnodeGlobalEntity ZnodeGlobalEntity { get; set; }
    }
}
