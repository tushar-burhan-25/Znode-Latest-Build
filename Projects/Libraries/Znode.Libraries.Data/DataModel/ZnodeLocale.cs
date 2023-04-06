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
    
    public partial class ZnodeLocale : ZnodeEntityBaseModel
    {
        public ZnodeLocale()
        {
            this.ZnodePimCategoryAttributeValueLocales = new HashSet<ZnodePimCategoryAttributeValueLocale>();
            this.ZnodePortalLocales = new HashSet<ZnodePortalLocale>();
            this.ZnodeProductFeeds = new HashSet<ZnodeProductFeed>();
            this.ZnodeCMSWidgetProfileVariants = new HashSet<ZnodeCMSWidgetProfileVariant>();
            this.ZnodeCMSContainerProfileVariantLocales = new HashSet<ZnodeCMSContainerProfileVariantLocale>();
            this.ZnodePublishContentContainerVariantEntities = new HashSet<ZnodePublishContentContainerVariantEntity>();
        }
    
        public int LocaleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodePimCategoryAttributeValueLocale> ZnodePimCategoryAttributeValueLocales { get; set; }
        public virtual ICollection<ZnodePortalLocale> ZnodePortalLocales { get; set; }
        public virtual ICollection<ZnodeProductFeed> ZnodeProductFeeds { get; set; }
        public virtual ICollection<ZnodeCMSWidgetProfileVariant> ZnodeCMSWidgetProfileVariants { get; set; }
        public virtual ICollection<ZnodeCMSContainerProfileVariantLocale> ZnodeCMSContainerProfileVariantLocales { get; set; }
        public virtual ICollection<ZnodePublishContentContainerVariantEntity> ZnodePublishContentContainerVariantEntities { get; set; }
    }
}