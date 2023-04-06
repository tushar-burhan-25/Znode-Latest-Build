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
    
    public partial class ZnodeGiftCardHistory : ZnodeEntityBaseModel
    {
        public int GiftCardHistoryId { get; set; }
        public int GiftCardId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public Nullable<int> OmsOrderDetailsId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> RemainingAmount { get; set; }
    
        public virtual ZnodeGiftCard ZnodeGiftCard { get; set; }
        public virtual ZnodeOmsOrderDetail ZnodeOmsOrderDetail { get; set; }
    }
}