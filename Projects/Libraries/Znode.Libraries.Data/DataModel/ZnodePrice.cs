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
    
    public partial class ZnodePrice : ZnodeEntityBaseModel
    {
        public int PriceId { get; set; }
        public Nullable<int> PriceListId { get; set; }
        public string SKU { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public Nullable<int> UomId { get; set; }
        public Nullable<decimal> UnitSize { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string ExternalId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
    
        public virtual ZnodeUom ZnodeUom { get; set; }
        public virtual ZnodePriceList ZnodePriceList { get; set; }
    }
}
