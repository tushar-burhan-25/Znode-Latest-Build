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
    
    public partial class ZnodeCMSCustomerReview : ZnodeEntityBaseModel
    {
        public int CMSCustomerReviewId { get; set; }
        public Nullable<int> PublishProductId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Headline { get; set; }
        public string Comments { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> PortalId { get; set; }
        public string SKU { get; set; }
    
        public virtual ZnodeUser ZnodeUser { get; set; }
    }
}