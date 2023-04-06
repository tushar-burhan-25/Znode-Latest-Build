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
    
    public partial class View_MediaAttributeValues : ZnodeEntityBaseModel
    {
        public int MediaCategoryId { get; set; }
        public Nullable<int> MediaId { get; set; }
        public Nullable<int> MediaPathId { get; set; }
        public Nullable<int> MediaAttributeFamilyId { get; set; }
        public string FamilyCode { get; set; }
        public Nullable<int> MediaAttributeId { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public string AttributeTypeName { get; set; }
        public string AttributeCode { get; set; }
        public Nullable<bool> IsRequired { get; set; }
        public Nullable<bool> IsLocalizable { get; set; }
        public Nullable<bool> IsFilterable { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public Nullable<int> MediaAttributeValueId { get; set; }
        public Nullable<int> MediaAttributeDefaultValueId { get; set; }
        public string DefaultAttributeValue { get; set; }
        public string MediaPath { get; set; }
        public int RowId { get; set; }
        public Nullable<bool> IsEditable { get; set; }
        public string ControlName { get; set; }
        public string ValidationName { get; set; }
        public string SubValidationName { get; set; }
        public string RegExp { get; set; }
        public string ValidationValue { get; set; }
        public Nullable<bool> IsRegExp { get; set; }
        public string AttributeGroupName { get; set; }
        public string HelpDescription { get; set; }
        public string MediaAttributeThumbnailPath { get; set; }
    }
}
