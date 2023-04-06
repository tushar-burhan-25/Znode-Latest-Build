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
    
    public partial class ZnodePublishState : ZnodeEntityBaseModel
    {
        public ZnodePublishState()
        {
            this.ZnodeCMSContentPages = new HashSet<ZnodeCMSContentPage>();
            this.ZnodeCMSMessages = new HashSet<ZnodeCMSMessage>();
            this.ZnodeCMSSEODetails = new HashSet<ZnodeCMSSEODetail>();
            this.ZnodeCMSSliders = new HashSet<ZnodeCMSSlider>();
            this.ZnodePimCategories = new HashSet<ZnodePimCategory>();
            this.ZnodePimProducts = new HashSet<ZnodePimProduct>();
            this.ZnodePublishCatalogLogs = new HashSet<ZnodePublishCatalogLog>();
            this.ZnodePublishPortalLogs = new HashSet<ZnodePublishPortalLog>();
            this.ZnodePublishStateApplicationTypeMappings = new HashSet<ZnodePublishStateApplicationTypeMapping>();
            this.ZnodeOmsOrders = new HashSet<ZnodeOmsOrder>();
            this.ZnodeOmsQuotes = new HashSet<ZnodeOmsQuote>();
            this.ZnodePortalShippings = new HashSet<ZnodePortalShipping>();
            this.ZnodePortalPaymentSettings = new HashSet<ZnodePortalPaymentSetting>();
            this.ZnodeProfilePaymentSettings = new HashSet<ZnodeProfilePaymentSetting>();
            this.ZnodeProfileShippings = new HashSet<ZnodeProfileShipping>();
            this.ZnodeCMSContainerProfileVariants = new HashSet<ZnodeCMSContainerProfileVariant>();
            this.ZnodeCMSContentContainers = new HashSet<ZnodeCMSContentContainer>();
        }
    
        public byte PublishStateId { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string PublishStateCode { get; set; }
        public string DisplayName { get; set; }
        public bool IsDefaultContentState { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsContentState { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<ZnodeCMSContentPage> ZnodeCMSContentPages { get; set; }
        public virtual ICollection<ZnodeCMSMessage> ZnodeCMSMessages { get; set; }
        public virtual ICollection<ZnodeCMSSEODetail> ZnodeCMSSEODetails { get; set; }
        public virtual ICollection<ZnodeCMSSlider> ZnodeCMSSliders { get; set; }
        public virtual ICollection<ZnodePimCategory> ZnodePimCategories { get; set; }
        public virtual ICollection<ZnodePimProduct> ZnodePimProducts { get; set; }
        public virtual ICollection<ZnodePublishCatalogLog> ZnodePublishCatalogLogs { get; set; }
        public virtual ICollection<ZnodePublishPortalLog> ZnodePublishPortalLogs { get; set; }
        public virtual ICollection<ZnodePublishStateApplicationTypeMapping> ZnodePublishStateApplicationTypeMappings { get; set; }
        public virtual ICollection<ZnodeOmsOrder> ZnodeOmsOrders { get; set; }
        public virtual ICollection<ZnodeOmsQuote> ZnodeOmsQuotes { get; set; }
        public virtual ICollection<ZnodePortalShipping> ZnodePortalShippings { get; set; }
        public virtual ICollection<ZnodePortalPaymentSetting> ZnodePortalPaymentSettings { get; set; }
        public virtual ICollection<ZnodeProfilePaymentSetting> ZnodeProfilePaymentSettings { get; set; }
        public virtual ICollection<ZnodeProfileShipping> ZnodeProfileShippings { get; set; }
        public virtual ICollection<ZnodeCMSContainerProfileVariant> ZnodeCMSContainerProfileVariants { get; set; }
        public virtual ICollection<ZnodeCMSContentContainer> ZnodeCMSContentContainers { get; set; }
    }
}