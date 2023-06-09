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
    
    public partial class ZnodeOmsOrderDiscount : ZnodeEntityBaseModel
    {
        public int OmsOrderDiscountId { get; set; }
        public Nullable<int> OmsOrderDetailsId { get; set; }
        public Nullable<int> OmsOrderLineItemId { get; set; }
        public Nullable<int> OmsDiscountTypeId { get; set; }
        public string DiscountCode { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<decimal> PerQuantityDiscount { get; set; }
        public Nullable<decimal> DiscountMultiplier { get; set; }
        public Nullable<int> ParentOmsOrderLineItemsId { get; set; }
        public Nullable<int> DiscountLevelTypeId { get; set; }
        public string PromotionName { get; set; }
        public Nullable<int> PromotionTypeId { get; set; }
        public Nullable<int> DiscountAppliedSequence { get; set; }
        public string PromotionMessage { get; set; }
    
        public virtual ZnodeOmsDiscountType ZnodeOmsDiscountType { get; set; }
        public virtual ZnodeOmsOrderDetail ZnodeOmsOrderDetail { get; set; }
        public virtual ZnodeOmsOrderLineItem ZnodeOmsOrderLineItem { get; set; }
    }
}
