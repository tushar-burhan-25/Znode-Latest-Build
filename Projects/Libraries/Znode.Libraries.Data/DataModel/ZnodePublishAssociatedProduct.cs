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
    
    public partial class ZnodePublishAssociatedProduct : ZnodeEntityBaseModel
    {
        public int PublishAssociatedProductId { get; set; }
        public Nullable<int> PimCatalogId { get; set; }
        public Nullable<int> ParentPimProductId { get; set; }
        public Nullable<int> PimProductId { get; set; }
        public Nullable<int> PublishStateId { get; set; }
        public Nullable<bool> IsConfigurable { get; set; }
        public Nullable<bool> IsBundle { get; set; }
        public Nullable<bool> IsGroup { get; set; }
        public Nullable<bool> IsAddOn { get; set; }
        public Nullable<bool> IsLink { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    }
}