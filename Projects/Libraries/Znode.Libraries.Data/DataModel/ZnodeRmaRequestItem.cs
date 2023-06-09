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
    
    public partial class ZnodeRmaRequestItem : ZnodeEntityBaseModel
    {
        public int RmaRequestItemId { get; set; }
        public Nullable<int> RmaRequestId { get; set; }
        public Nullable<int> OmsOrderLineItemsId { get; set; }
        public bool IsReceived { get; set; }
        public bool IsReturnable { get; set; }
        public Nullable<int> GiftCardId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> RmaReasonForReturnId { get; set; }
        public string TransactionId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeGiftCard ZnodeGiftCard { get; set; }
        public virtual ZnodeOmsOrderLineItem ZnodeOmsOrderLineItem { get; set; }
        public virtual ZnodeRmaReasonForReturn ZnodeRmaReasonForReturn { get; set; }
        public virtual ZnodeRmaRequest ZnodeRmaRequest { get; set; }
    }
}
