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
    
    public partial class ZnodeOmsQuoteComment : ZnodeEntityBaseModel
    {
        public ZnodeOmsQuoteComment()
        {
            this.ZnodeOMSQuoteApprovals = new HashSet<ZnodeOMSQuoteApproval>();
        }
    
        public int OmsQuoteCommentId { get; set; }
        public Nullable<int> OmsQuoteId { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeOMSQuoteApproval> ZnodeOMSQuoteApprovals { get; set; }
        public virtual ZnodeOmsQuote ZnodeOmsQuote { get; set; }
    }
}
