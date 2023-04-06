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
    
    public partial class ZnodeOmsOrder : ZnodeEntityBaseModel
    {
        public ZnodeOmsOrder()
        {
            this.ZnodeOmsOrderLineItemsShippings = new HashSet<ZnodeOmsOrderLineItemsShipping>();
            this.ZnodeRmaReturnDetails = new HashSet<ZnodeRmaReturnDetail>();
            this.ZnodeOrderPayments = new HashSet<ZnodeOrderPayment>();
            this.ZnodeOmsTaxRules = new HashSet<ZnodeOmsTaxRule>();
        }
    
        public int OmsOrderId { get; set; }
        public bool IsQuoteOrder { get; set; }
        public string OrderNumber { get; set; }
        public string ExternalId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> OMSQuoteId { get; set; }
        public Nullable<byte> PublishStateId { get; set; }
        public bool IsOldOrder { get; set; }
    
        public virtual ZnodeOmsQuote ZnodeOmsQuote { get; set; }
        public virtual ZnodePublishState ZnodePublishState { get; set; }
        public virtual ICollection<ZnodeOmsOrderLineItemsShipping> ZnodeOmsOrderLineItemsShippings { get; set; }
        public virtual ICollection<ZnodeOmsOrderDetail> ZnodeOmsOrderDetails { get; set; }
        public virtual ICollection<ZnodeRmaReturnDetail> ZnodeRmaReturnDetails { get; set; }
        public virtual ICollection<ZnodeOrderPayment> ZnodeOrderPayments { get; set; }
        public virtual ICollection<ZnodeOmsTaxRule> ZnodeOmsTaxRules { get; set; }
    }
}