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
    
    public partial class ZnodePublishAddonEntity : ZnodeEntityBaseModel
    {
        public int PublishAddonEntityId { get; set; }
        public int VersionId { get; set; }
        public int ZnodeProductId { get; set; }
        public int ZnodeCatalogId { get; set; }
        public int AssociatedZnodeProductId { get; set; }
        public int AssociatedProductDisplayOrder { get; set; }
        public int LocaleId { get; set; }
        public string GroupName { get; set; }
        public string DisplayType { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsRequired { get; set; }
        public string RequiredType { get; set; }
        public bool IsDefault { get; set; }
    }
}