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
    
    public partial class ZnodePimAttribute : ZnodeEntityBaseModel
    {
        public ZnodePimAttribute()
        {
            this.ZnodePimAttribute1 = new HashSet<ZnodePimAttribute>();
            this.ZnodePimAttributeDefaultValues = new HashSet<ZnodePimAttributeDefaultValue>();
            this.ZnodePimAttributeGroupMappers = new HashSet<ZnodePimAttributeGroupMapper>();
            this.ZnodePimAttributeLocales = new HashSet<ZnodePimAttributeLocale>();
            this.ZnodePimAttributeValidations = new HashSet<ZnodePimAttributeValidation>();
            this.ZnodePimAttributeValues = new HashSet<ZnodePimAttributeValue>();
            this.ZnodePimCategoryAttributeValues = new HashSet<ZnodePimCategoryAttributeValue>();
            this.ZnodePimFamilyGroupMappers = new HashSet<ZnodePimFamilyGroupMapper>();
            this.ZnodePimFrontendProperties = new HashSet<ZnodePimFrontendProperty>();
            this.ZnodePimProductImages = new HashSet<ZnodePimProductImage>();
            this.ZnodePimVendors = new HashSet<ZnodePimVendor>();
            this.ZnodePimLinkProductDetails = new HashSet<ZnodePimLinkProductDetail>();
            this.ZnodePimProductTypeAssociations = new HashSet<ZnodePimProductTypeAssociation>();
        }
    
        public int PimAttributeId { get; set; }
        public Nullable<int> ParentPimAttributeId { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public string AttributeCode { get; set; }
        public bool IsRequired { get; set; }
        public bool IsLocalizable { get; set; }
        public bool IsFilterable { get; set; }
        public bool IsSystemDefined { get; set; }
        public bool IsConfigurable { get; set; }
        public bool IsPersonalizable { get; set; }
        public Nullable<bool> IsShowOnGrid { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string HelpDescription { get; set; }
        public bool IsCategory { get; set; }
        public Nullable<bool> IsHidden { get; set; }
        public Nullable<bool> IsSwatch { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAttributeType ZnodeAttributeType { get; set; }
        public virtual ICollection<ZnodePimAttribute> ZnodePimAttribute1 { get; set; }
        public virtual ZnodePimAttribute ZnodePimAttribute2 { get; set; }
        public virtual ICollection<ZnodePimAttributeDefaultValue> ZnodePimAttributeDefaultValues { get; set; }
        public virtual ICollection<ZnodePimAttributeGroupMapper> ZnodePimAttributeGroupMappers { get; set; }
        public virtual ICollection<ZnodePimAttributeLocale> ZnodePimAttributeLocales { get; set; }
        public virtual ICollection<ZnodePimAttributeValidation> ZnodePimAttributeValidations { get; set; }
        public virtual ICollection<ZnodePimAttributeValue> ZnodePimAttributeValues { get; set; }
        public virtual ICollection<ZnodePimCategoryAttributeValue> ZnodePimCategoryAttributeValues { get; set; }
        public virtual ICollection<ZnodePimFamilyGroupMapper> ZnodePimFamilyGroupMappers { get; set; }
        public virtual ICollection<ZnodePimFrontendProperty> ZnodePimFrontendProperties { get; set; }
        public virtual ICollection<ZnodePimProductImage> ZnodePimProductImages { get; set; }
        public virtual ICollection<ZnodePimVendor> ZnodePimVendors { get; set; }
        public virtual ICollection<ZnodePimLinkProductDetail> ZnodePimLinkProductDetails { get; set; }
        public virtual ICollection<ZnodePimProductTypeAssociation> ZnodePimProductTypeAssociations { get; set; }
    }
}