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
    
    public partial class ZnodePublishCatalogAttributeEntity : ZnodeEntityBaseModel
    {
        public int PublishCatalogAttributeEntityId { get; set; }
        public int VersionId { get; set; }
        public int ZnodeCatalogId { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeTypeName { get; set; }
        public bool IsPromoRuleCondition { get; set; }
        public bool IsComparable { get; set; }
        public bool IsHtmlTags { get; set; }
        public bool IsFacets { get; set; }
        public bool IsUseInSearch { get; set; }
        public bool IsPersonalizable { get; set; }
        public bool IsConfigurable { get; set; }
        public string AttributeName { get; set; }
        public int LocaleId { get; set; }
        public int DisplayOrder { get; set; }
        public string SelectValues { get; set; }
    }
}
