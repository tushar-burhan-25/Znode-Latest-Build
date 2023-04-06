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
    
    public partial class ZnodeMediaAttributeDefaultValue : ZnodeEntityBaseModel
    {
        public ZnodeMediaAttributeDefaultValue()
        {
            this.ZnodeMediaAttributeDefaultValueLocales = new HashSet<ZnodeMediaAttributeDefaultValueLocale>();
            this.ZnodeMediaAttributeValues = new HashSet<ZnodeMediaAttributeValue>();
        }
    
        public int MediaAttributeDefaultValueId { get; set; }
        public Nullable<int> MediaAttributeId { get; set; }
        public string AttributeDefaultValueCode { get; set; }
        public Nullable<bool> IsEditable { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeMediaAttribute ZnodeMediaAttribute { get; set; }
        public virtual ICollection<ZnodeMediaAttributeDefaultValueLocale> ZnodeMediaAttributeDefaultValueLocales { get; set; }
        public virtual ICollection<ZnodeMediaAttributeValue> ZnodeMediaAttributeValues { get; set; }
    }
}
