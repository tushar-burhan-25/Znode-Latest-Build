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
    
    public partial class ZnodeAttributeType : ZnodeEntityBaseModel
    {
        public ZnodeAttributeType()
        {
            this.ZnodeAttributeInputValidations = new HashSet<ZnodeAttributeInputValidation>();
            this.ZnodeMediaAttributes = new HashSet<ZnodeMediaAttribute>();
            this.ZnodePimAttributes = new HashSet<ZnodePimAttribute>();
            this.ZnodePromotionAttributes = new HashSet<ZnodePromotionAttribute>();
            this.ZnodeGlobalAttributes = new HashSet<ZnodeGlobalAttribute>();
        }
    
        public int AttributeTypeId { get; set; }
        public string AttributeTypeName { get; set; }
        public Nullable<bool> IsMediaAttributeType { get; set; }
        public Nullable<bool> IsPimAttributeType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeAttributeInputValidation> ZnodeAttributeInputValidations { get; set; }
        public virtual ICollection<ZnodeMediaAttribute> ZnodeMediaAttributes { get; set; }
        public virtual ICollection<ZnodePimAttribute> ZnodePimAttributes { get; set; }
        public virtual ICollection<ZnodePromotionAttribute> ZnodePromotionAttributes { get; set; }
        public virtual ICollection<ZnodeGlobalAttribute> ZnodeGlobalAttributes { get; set; }
    }
}
