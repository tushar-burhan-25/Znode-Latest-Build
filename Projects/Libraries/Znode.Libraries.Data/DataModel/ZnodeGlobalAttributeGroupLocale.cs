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
    
    public partial class ZnodeGlobalAttributeGroupLocale : ZnodeEntityBaseModel
    {
        public int GlobalAttributeGroupLocaleId { get; set; }
        public Nullable<int> LocaleId { get; set; }
        public int GlobalAttributeGroupId { get; set; }
        public string AttributeGroupName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeGlobalAttributeGroup ZnodeGlobalAttributeGroup { get; set; }
    }
}