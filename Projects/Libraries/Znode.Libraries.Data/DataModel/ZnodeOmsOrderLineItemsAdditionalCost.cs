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
    
    public partial class ZnodeOmsOrderLineItemsAdditionalCost : ZnodeEntityBaseModel
    {
        public int OmsOrderLineItemsAdditionalCostId { get; set; }
        public Nullable<int> OmsOrderLineItemsId { get; set; }
        public string KeyName { get; set; }
        public decimal KeyValue { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeOmsOrderLineItem ZnodeOmsOrderLineItem { get; set; }
    }
}
