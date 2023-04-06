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
    
    public partial class ZnodePromotionAttributeValidation : ZnodeEntityBaseModel
    {
        public int PromotionAttributeValidationId { get; set; }
        public Nullable<int> PromotionAttributeId { get; set; }
        public Nullable<int> InputValidationId { get; set; }
        public Nullable<int> InputValidationRuleId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAttributeInputValidation ZnodeAttributeInputValidation { get; set; }
        public virtual ZnodeAttributeInputValidationRule ZnodeAttributeInputValidationRule { get; set; }
        public virtual ZnodePromotionAttribute ZnodePromotionAttribute { get; set; }
        public virtual ZnodePromotionAttributeValidation ZnodePromotionAttributeValidation1 { get; set; }
        public virtual ZnodePromotionAttributeValidation ZnodePromotionAttributeValidation2 { get; set; }
    }
}
