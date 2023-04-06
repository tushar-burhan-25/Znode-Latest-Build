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
    
    public partial class ZnodeOmsOrderWarehouse : ZnodeEntityBaseModel
    {
        public int OmsOrderWarehouseId { get; set; }
        public Nullable<int> OmsOrderDetailsId { get; set; }
        public Nullable<int> OmsOrderLineItemsId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeOmsOrderLineItem ZnodeOmsOrderLineItem { get; set; }
        public virtual ZnodeWarehouse ZnodeWarehouse { get; set; }
        public virtual ZnodeOmsOrderDetail ZnodeOmsOrderDetail { get; set; }
    }
}
