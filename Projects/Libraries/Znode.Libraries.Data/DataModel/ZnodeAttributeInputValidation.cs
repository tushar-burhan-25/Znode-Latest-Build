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
    
    public partial class ZnodeAttributeInputValidation : ZnodeEntityBaseModel
    {
        public ZnodeAttributeInputValidation()
        {
            this.ZnodeAttributeInputValidationRules = new HashSet<ZnodeAttributeInputValidationRule>();
            this.ZnodeGlobalAttributeValidations = new HashSet<ZnodeGlobalAttributeValidation>();
            this.ZnodeMediaAttributeValidations = new HashSet<ZnodeMediaAttributeValidation>();
            this.ZnodePimAttributeValidations = new HashSet<ZnodePimAttributeValidation>();
            this.ZnodePromotionAttributeValidations = new HashSet<ZnodePromotionAttributeValidation>();
        }
    
        public int InputValidationId { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<bool> IsList { get; set; }
        public string ControlName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAttributeType ZnodeAttributeType { get; set; }
        public virtual ICollection<ZnodeAttributeInputValidationRule> ZnodeAttributeInputValidationRules { get; set; }
        public virtual ICollection<ZnodeGlobalAttributeValidation> ZnodeGlobalAttributeValidations { get; set; }
        public virtual ICollection<ZnodeMediaAttributeValidation> ZnodeMediaAttributeValidations { get; set; }
        public virtual ICollection<ZnodePimAttributeValidation> ZnodePimAttributeValidations { get; set; }
        public virtual ICollection<ZnodePromotionAttributeValidation> ZnodePromotionAttributeValidations { get; set; }
    }
}
