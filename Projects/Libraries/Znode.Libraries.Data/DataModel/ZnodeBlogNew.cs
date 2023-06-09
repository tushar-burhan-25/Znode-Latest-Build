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

    public partial class ZnodeBlogNew : ZnodeEntityBaseModel
    {
        public ZnodeBlogNew()
        {
            this.ZnodeBlogNewsComments = new HashSet<ZnodeBlogNewsComment>();
            this.ZnodeBlogNewsContents = new HashSet<ZnodeBlogNewsContent>();
            this.ZnodeBlogNewsLocales = new HashSet<ZnodeBlogNewsLocale>();
        }

        public int BlogNewsId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public Nullable<int> MediaId { get; set; }
        public Nullable<int> CMSContentPagesId { get; set; }
        public string BlogNewsType { get; set; }
        public Nullable<bool> IsBlogNewsActive { get; set; }
        public Nullable<bool> IsAllowGuestComment { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string BlogNewsCode { get; set; }
        public byte PublishStateId { get; set; }

        public virtual ICollection<ZnodeBlogNewsComment> ZnodeBlogNewsComments { get; set; }
        public virtual ZnodeCMSContentPage ZnodeCMSContentPage { get; set; }
        public virtual ZnodeMedia ZnodeMedia { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
        public virtual ICollection<ZnodeBlogNewsContent> ZnodeBlogNewsContents { get; set; }
        public virtual ICollection<ZnodeBlogNewsLocale> ZnodeBlogNewsLocales { get; set; }
    }
}
