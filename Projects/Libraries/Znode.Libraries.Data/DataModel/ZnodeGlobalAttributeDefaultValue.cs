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
    
    public partial class ZnodeGlobalAttributeDefaultValue : ZnodeEntityBaseModel
    {
        public ZnodeGlobalAttributeDefaultValue()
        {
            this.ZnodeGlobalAttributeDefaultValueLocales = new HashSet<ZnodeGlobalAttributeDefaultValueLocale>();
            this.ZnodeGlobalAttributeValues = new HashSet<ZnodeGlobalAttributeValue>();
            this.ZnodePortalGlobalAttributeValues = new HashSet<ZnodePortalGlobalAttributeValue>();
            this.ZnodeAccountGlobalAttributeValues = new HashSet<ZnodeAccountGlobalAttributeValue>();
            this.ZnodeUserGlobalAttributeValues = new HashSet<ZnodeUserGlobalAttributeValue>();
            this.ZnodeWidgetGlobalAttributeValues = new HashSet<ZnodeWidgetGlobalAttributeValue>();
        }
    
        public int GlobalAttributeDefaultValueId { get; set; }
        public Nullable<int> GlobalAttributeId { get; set; }
        public string AttributeDefaultValueCode { get; set; }
        public Nullable<bool> IsEditable { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<int> MediaId { get; set; }
        public string SwatchText { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeGlobalAttributeDefaultValueLocale> ZnodeGlobalAttributeDefaultValueLocales { get; set; }
        public virtual ICollection<ZnodeGlobalAttributeValue> ZnodeGlobalAttributeValues { get; set; }
        public virtual ICollection<ZnodePortalGlobalAttributeValue> ZnodePortalGlobalAttributeValues { get; set; }
        public virtual ZnodeGlobalAttribute ZnodeGlobalAttribute { get; set; }
        public virtual ICollection<ZnodeAccountGlobalAttributeValue> ZnodeAccountGlobalAttributeValues { get; set; }
        public virtual ICollection<ZnodeUserGlobalAttributeValue> ZnodeUserGlobalAttributeValues { get; set; }
        public virtual ICollection<ZnodeWidgetGlobalAttributeValue> ZnodeWidgetGlobalAttributeValues { get; set; }
    }
}
