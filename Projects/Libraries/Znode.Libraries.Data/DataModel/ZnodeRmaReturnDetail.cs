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
    
    public partial class ZnodeRmaReturnDetail : ZnodeEntityBaseModel
    {
        public ZnodeRmaReturnDetail()
        {
            this.ZnodeRmaReturnEmailHistories = new HashSet<ZnodeRmaReturnEmailHistory>();
            this.ZnodeRmaReturnHistories = new HashSet<ZnodeRmaReturnHistory>();
            this.ZnodeRmaReturnLineItems = new HashSet<ZnodeRmaReturnLineItem>();
            this.ZnodeRmaReturnNotes = new HashSet<ZnodeRmaReturnNote>();
            this.ZnodeRmaReturnPaymentDetails = new HashSet<ZnodeRmaReturnPaymentDetail>();
            this.ZnodeRmaReturnPaymentRefunds = new HashSet<ZnodeRmaReturnPaymentRefund>();
        }
    
        public int RmaReturnDetailsId { get; set; }
        public int OmsOrderId { get; set; }
        public int OmsOrderDetailsId { get; set; }
        public string OrderNumber { get; set; }
        public string ReturnNumber { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public int RmaReturnStateId { get; set; }
        public decimal TotalExpectedReturnQuantity { get; set; }
        public string EmailId { get; set; }
        public int PortalId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> ShippingId { get; set; }
        public string ShippingNumber { get; set; }
        public Nullable<bool> IsTaxCostEdited { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> ReturnShippingCost { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> ReturnTaxCost { get; set; }
        public Nullable<decimal> TotalReturnAmount { get; set; }
        public bool IsActive { get; set; }
        public string CurrencyCode { get; set; }
        public string CultureCode { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<decimal> OverDueAmount { get; set; }
        public bool IsRefundProcess { get; set; }
        public Nullable<decimal> CSRDiscount { get; set; }
        public Nullable<decimal> ReturnShippingDiscount { get; set; }
        public Nullable<decimal> ReturnCharges { get; set; }
        public Nullable<decimal> VoucherAmount { get; set; }
        public Nullable<decimal> ImportDuty { get; set; }
    
        public virtual ZnodeOmsOrder ZnodeOmsOrder { get; set; }
        public virtual ZnodeOmsOrderDetail ZnodeOmsOrderDetail { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
        public virtual ZnodeRmaReturnState ZnodeRmaReturnState { get; set; }
        public virtual ZnodeUser ZnodeUser { get; set; }
        public virtual ICollection<ZnodeRmaReturnEmailHistory> ZnodeRmaReturnEmailHistories { get; set; }
        public virtual ICollection<ZnodeRmaReturnHistory> ZnodeRmaReturnHistories { get; set; }
        public virtual ICollection<ZnodeRmaReturnLineItem> ZnodeRmaReturnLineItems { get; set; }
        public virtual ICollection<ZnodeRmaReturnNote> ZnodeRmaReturnNotes { get; set; }
        public virtual ICollection<ZnodeRmaReturnPaymentDetail> ZnodeRmaReturnPaymentDetails { get; set; }
        public virtual ICollection<ZnodeRmaReturnPaymentRefund> ZnodeRmaReturnPaymentRefunds { get; set; }
    }
}
