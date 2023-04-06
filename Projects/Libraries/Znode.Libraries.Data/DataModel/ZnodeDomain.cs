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
    
    public partial class ZnodeDomain : ZnodeEntityBaseModel
    {
        public ZnodeDomain()
        {
            this.ZnodeOmsUsersReferralUrls = new HashSet<ZnodeOmsUsersReferralUrl>();
            this.ZnodePortalLoginProviders = new HashSet<ZnodePortalLoginProvider>();
        }
    
        public int DomainId { get; set; }
        public int PortalId { get; set; }
        public string DomainName { get; set; }
        public bool IsActive { get; set; }
        public string ApiKey { get; set; }
        public string ApplicationType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual ICollection<ZnodeOmsUsersReferralUrl> ZnodeOmsUsersReferralUrls { get; set; }
        public virtual ICollection<ZnodePortalLoginProvider> ZnodePortalLoginProviders { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
    }
}
