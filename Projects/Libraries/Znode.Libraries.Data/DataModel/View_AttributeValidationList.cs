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
    
    public partial class View_AttributeValidationList : ZnodeEntityBaseModel
    {
        public Nullable<int> MediaAttributeId { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public string AttributeTypeName { get; set; }
        public string AttributeCode { get; set; }
        public Nullable<bool> IsRequired { get; set; }
        public Nullable<bool> IsLocalizable { get; set; }
        public Nullable<bool> IsFilterable { get; set; }
        public string AttributeName { get; set; }
        public string ControlName { get; set; }
        public string ValidationName { get; set; }
        public string SubValidationName { get; set; }
        public string ValidationValue { get; set; }
        public string RegExp { get; set; }
        public Nullable<bool> IsRegExp { get; set; }
        public int RowId { get; set; }
    }
}
