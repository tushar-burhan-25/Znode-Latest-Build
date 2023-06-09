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
    
    public partial class ZnodePromotionAttribute : ZnodeEntityBaseModel
    {
        public ZnodePromotionAttribute()
        {
            this.ZnodePromotionAttributeValidations = new HashSet<ZnodePromotionAttributeValidation>();
            this.ZnodePromotionDiscountAttributeMappers = new HashSet<ZnodePromotionDiscountAttributeMapper>();
        }
    
        public int PromotionAttributeId { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeName { get; set; }
        public bool IsRequired { get; set; }
        public bool IsLocalizable { get; set; }
        public string HelpDescription { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAttributeType ZnodeAttributeType { get; set; }
        public virtual ICollection<ZnodePromotionAttributeValidation> ZnodePromotionAttributeValidations { get; set; }
        public virtual ICollection<ZnodePromotionDiscountAttributeMapper> ZnodePromotionDiscountAttributeMappers { get; set; }
    }
}
