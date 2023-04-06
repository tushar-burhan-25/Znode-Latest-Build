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
    
    public partial class ZnodePortalApproval : ZnodeEntityBaseModel
    {
        public ZnodePortalApproval()
        {
            this.ZnodePortalPaymentGroups = new HashSet<ZnodePortalPaymentGroup>();
            this.ZnodeUserApprovers = new HashSet<ZnodeUserApprover>();
        }
    
        public int PortalApprovalId { get; set; }
        public bool EnableApprovalManagement { get; set; }
        public int PortalApprovalTypeId { get; set; }
        public int PortalApprovalLevelId { get; set; }
        public decimal OrderLimit { get; set; }
        public int PortalId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodePortalApprovalLevel ZnodePortalApprovalLevel { get; set; }
        public virtual ZnodePortalApprovalType ZnodePortalApprovalType { get; set; }
        public virtual ICollection<ZnodePortalPaymentGroup> ZnodePortalPaymentGroups { get; set; }
        public virtual ICollection<ZnodeUserApprover> ZnodeUserApprovers { get; set; }
    }
}