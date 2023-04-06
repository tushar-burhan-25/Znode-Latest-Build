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
    
    public partial class ZnodeCaseRequest : ZnodeEntityBaseModel
    {
        public ZnodeCaseRequest()
        {
            this.ZnodeCaseRequestHistories = new HashSet<ZnodeCaseRequestHistory>();
            this.ZnodeNotes = new HashSet<ZnodeNote>();
        }
    
        public int CaseRequestId { get; set; }
        public int PortalId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OwnerUserId { get; set; }
        public Nullable<int> CaseStatusId { get; set; }
        public Nullable<int> CasePriorityId { get; set; }
        public Nullable<int> CaseTypeId { get; set; }
        public string CaseOrigin { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
    
        public virtual ZnodeCasePriority ZnodeCasePriority { get; set; }
        public virtual ZnodeCaseStatu ZnodeCaseStatu { get; set; }
        public virtual ZnodeCaseType ZnodeCaseType { get; set; }
        public virtual ICollection<ZnodeCaseRequestHistory> ZnodeCaseRequestHistories { get; set; }
        public virtual ICollection<ZnodeNote> ZnodeNotes { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
        public virtual ZnodeUser ZnodeUser { get; set; }
        public virtual ZnodeUser ZnodeUser1 { get; set; }
    }
}