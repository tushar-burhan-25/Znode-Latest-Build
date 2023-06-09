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
    
    public partial class ZnodeCMSContentPage : ZnodeEntityBaseModel
    {
        public ZnodeCMSContentPage()
        {
            this.ZnodeBlogNews = new HashSet<ZnodeBlogNew>();
            this.ZnodeCMSContentPageGroupMappings = new HashSet<ZnodeCMSContentPageGroupMapping>();
            this.ZnodeCMSContentPagesLocales = new HashSet<ZnodeCMSContentPagesLocale>();
            this.ZnodeCMSContentPagesProfiles = new HashSet<ZnodeCMSContentPagesProfile>();
            this.ZnodeFormWidgetEmailConfigurations = new HashSet<ZnodeFormWidgetEmailConfiguration>();
        }
    
        public int CMSContentPagesId { get; set; }
        public int PortalId { get; set; }
        public int CMSTemplateId { get; set; }
        public string PageName { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public byte PublishStateId { get; set; }
    
        public virtual ICollection<ZnodeBlogNew> ZnodeBlogNews { get; set; }
        public virtual ICollection<ZnodeCMSContentPageGroupMapping> ZnodeCMSContentPageGroupMappings { get; set; }
        public virtual ZnodePublishState ZnodePublishState { get; set; }
        public virtual ZnodeCMSTemplate ZnodeCMSTemplate { get; set; }
        public virtual ICollection<ZnodeCMSContentPagesLocale> ZnodeCMSContentPagesLocales { get; set; }
        public virtual ICollection<ZnodeCMSContentPagesProfile> ZnodeCMSContentPagesProfiles { get; set; }
        public virtual ICollection<ZnodeFormWidgetEmailConfiguration> ZnodeFormWidgetEmailConfigurations { get; set; }
    }
}
