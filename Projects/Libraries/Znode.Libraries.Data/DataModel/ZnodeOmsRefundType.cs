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
    
    public partial class ZnodeOmsRefundType : ZnodeEntityBaseModel
    {
        public ZnodeOmsRefundType()
        {
            this.ZnodeOmsPaymentRefunds = new HashSet<ZnodeOmsPaymentRefund>();
            this.ZnodeRmaReturnPaymentRefunds = new HashSet<ZnodeRmaReturnPaymentRefund>();
        }
    
        public int OmsRefundTypeId { get; set; }
        public string RefundType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeOmsPaymentRefund> ZnodeOmsPaymentRefunds { get; set; }
        public virtual ICollection<ZnodeRmaReturnPaymentRefund> ZnodeRmaReturnPaymentRefunds { get; set; }
    }
}
