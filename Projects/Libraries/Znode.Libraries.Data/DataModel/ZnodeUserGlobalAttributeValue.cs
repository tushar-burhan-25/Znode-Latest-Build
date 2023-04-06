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
    
    public partial class ZnodeUserGlobalAttributeValue : ZnodeEntityBaseModel
    {
        public ZnodeUserGlobalAttributeValue()
        {
            this.ZnodeUserGlobalAttributeValueLocales = new HashSet<ZnodeUserGlobalAttributeValueLocale>();
        }
    
        public int UserGlobalAttributeValueId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> GlobalAttributeId { get; set; }
        public Nullable<int> GlobalAttributeDefaultValueId { get; set; }
        public string AttributeValue { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeGlobalAttribute ZnodeGlobalAttribute { get; set; }
        public virtual ZnodeGlobalAttributeDefaultValue ZnodeGlobalAttributeDefaultValue { get; set; }
        public virtual ICollection<ZnodeUserGlobalAttributeValueLocale> ZnodeUserGlobalAttributeValueLocales { get; set; }
    }
}
