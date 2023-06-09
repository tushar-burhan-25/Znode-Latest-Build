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
    
    public partial class ZnodeRmaReturnState : ZnodeEntityBaseModel
    {
        public ZnodeRmaReturnState()
        {
            this.ZnodeRmaReturnLineItems = new HashSet<ZnodeRmaReturnLineItem>();
            this.ZnodeRmaReturnDetails = new HashSet<ZnodeRmaReturnDetail>();
        }
    
        public int RmaReturnStateId { get; set; }
        public string ReturnStateName { get; set; }
        public int DisplayOrder { get; set; }
        public string Description { get; set; }
        public bool IsReturnState { get; set; }
        public bool IsReturnLineItemState { get; set; }
        public bool IsSendEmail { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeRmaReturnLineItem> ZnodeRmaReturnLineItems { get; set; }
        public virtual ICollection<ZnodeRmaReturnDetail> ZnodeRmaReturnDetails { get; set; }
    }
}
