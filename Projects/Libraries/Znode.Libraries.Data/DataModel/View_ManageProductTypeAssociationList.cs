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
    
    public partial class View_ManageProductTypeAssociationList : ZnodeEntityBaseModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string AttributeFamily { get; set; }
        public string SKU { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Status { get; set; }
        public string Assortment { get; set; }
        public Nullable<int> PimProductTypeAssociationId { get; set; }
        public Nullable<int> RelatedProductId { get; set; }
        public Nullable<int> LocaleId { get; set; }
    }
}
