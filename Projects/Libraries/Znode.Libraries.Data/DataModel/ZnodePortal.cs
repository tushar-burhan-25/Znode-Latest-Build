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
    
    public partial class ZnodePortal : ZnodeEntityBaseModel
    {
        public ZnodePortal()
        {
            this.AspNetZnodeUsers = new HashSet<AspNetZnodeUser>();
            this.ZnodeActivityLogs = new HashSet<ZnodeActivityLog>();
            this.ZnodeBlogNews = new HashSet<ZnodeBlogNew>();
            this.ZnodeBrandPortals = new HashSet<ZnodeBrandPortal>();
            this.ZnodeCaseRequests = new HashSet<ZnodeCaseRequest>();
            this.ZnodeCMSPortalMessages = new HashSet<ZnodeCMSPortalMessage>();
            this.ZnodeCMSPortalMessageKeyTags = new HashSet<ZnodeCMSPortalMessageKeyTag>();
            this.ZnodeCMSPortalProductPages = new HashSet<ZnodeCMSPortalProductPage>();
            this.ZnodeCMSPortalSEOSettings = new HashSet<ZnodeCMSPortalSEOSetting>();
            this.ZnodeCMSPortalThemes = new HashSet<ZnodeCMSPortalTheme>();
            this.ZnodeCMSUrlRedirects = new HashSet<ZnodeCMSUrlRedirect>();
            this.ZnodeDomains = new HashSet<ZnodeDomain>();
            this.ZnodeFormBuilderSubmits = new HashSet<ZnodeFormBuilderSubmit>();
            this.ZnodePortalProfiles = new HashSet<ZnodePortalProfile>();
            this.ZnodePortalAccounts = new HashSet<ZnodePortalAccount>();
            this.ZnodePortalAddresses = new HashSet<ZnodePortalAddress>();
            this.ZnodePortalCatalogs = new HashSet<ZnodePortalCatalog>();
            this.ZnodePortalCustomCsses = new HashSet<ZnodePortalCustomCss>();
            this.ZnodePortalFeatureMappers = new HashSet<ZnodePortalFeatureMapper>();
            this.ZnodePortalLocales = new HashSet<ZnodePortalLocale>();
            this.ZnodePortalLoginProviders = new HashSet<ZnodePortalLoginProvider>();
            this.ZnodePortalPageSettings = new HashSet<ZnodePortalPageSetting>();
            this.ZnodePortalPaymentSettings = new HashSet<ZnodePortalPaymentSetting>();
            this.ZnodePortalSearchProfiles = new HashSet<ZnodePortalSearchProfile>();
            this.ZnodePortalShippings = new HashSet<ZnodePortalShipping>();
            this.ZnodePortalShippingDetails = new HashSet<ZnodePortalShippingDetail>();
            this.ZnodePortalSortSettings = new HashSet<ZnodePortalSortSetting>();
            this.ZnodePortalTaxClasses = new HashSet<ZnodePortalTaxClass>();
            this.ZnodePortalUnits = new HashSet<ZnodePortalUnit>();
            this.ZnodePortalWarehouses = new HashSet<ZnodePortalWarehouse>();
            this.ZnodePriceListPortals = new HashSet<ZnodePriceListPortal>();
            this.ZnodeRobotsTxts = new HashSet<ZnodeRobotsTxt>();
            this.ZnodeShippingPortals = new HashSet<ZnodeShippingPortal>();
            this.ZnodePortalSmtpSettings = new HashSet<ZnodePortalSmtpSetting>();
            this.ZnodeTaxPortals = new HashSet<ZnodeTaxPortal>();
            this.ZnodeTaxRuleTypes = new HashSet<ZnodeTaxRuleType>();
            this.ZnodeUserPortals = new HashSet<ZnodeUserPortal>();
            this.ZnodeImpersonationLogs = new HashSet<ZnodeImpersonationLog>();
            this.ZnodePortalRecommendationSettings = new HashSet<ZnodePortalRecommendationSetting>();
            this.ZnodeSalesRepCustomerUserPortals = new HashSet<ZnodeSalesRepCustomerUserPortal>();
            this.ZnodePortalBrands = new HashSet<ZnodePortalBrand>();
            this.ZnodeSearchActivities = new HashSet<ZnodeSearchActivity>();
            this.ZnodeGoogleTagManagers = new HashSet<ZnodeGoogleTagManager>();
            this.ZnodeRmaReturnDetails = new HashSet<ZnodeRmaReturnDetail>();
            this.ZnodePortalKlaviyoSettings = new HashSet<ZnodePortalKlaviyoSetting>();
            this.ZnodeProductFeeds = new HashSet<ZnodeProductFeed>();
        }
    
        public int PortalId { get; set; }
        public string CompanyName { get; set; }
        public string StoreName { get; set; }
        public string LogoPath { get; set; }
        public bool UseSSL { get; set; }
        public string AdminEmail { get; set; }
        public string SalesEmail { get; set; }
        public string CustomerServiceEmail { get; set; }
        public string SalesPhoneNumber { get; set; }
        public string CustomerServicePhoneNumber { get; set; }
        public string ImageNotAvailablePath { get; set; }
        public bool ShowSwatchInCategory { get; set; }
        public bool ShowAlternateImageInCategory { get; set; }
        public string ExternalID { get; set; }
        public string MobileLogoPath { get; set; }
        public Nullable<int> DefaultOrderStateID { get; set; }
        public string DefaultReviewStatus { get; set; }
        public Nullable<int> SplashCategoryID { get; set; }
        public string SplashImageFile { get; set; }
        public string MobileTheme { get; set; }
        public Nullable<int> CopyContentBasedOnPortalId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string InStockMsg { get; set; }
        public string OutOfStockMsg { get; set; }
        public string BackOrderMsg { get; set; }
        public Nullable<decimal> OrderAmount { get; set; }
        public string Email { get; set; }
        public string StoreCode { get; set; }
        public string UserVerificationType { get; set; }
    
        public virtual ICollection<AspNetZnodeUser> AspNetZnodeUsers { get; set; }
        public virtual ICollection<ZnodeActivityLog> ZnodeActivityLogs { get; set; }
        public virtual ICollection<ZnodeBlogNew> ZnodeBlogNews { get; set; }
        public virtual ICollection<ZnodeBrandPortal> ZnodeBrandPortals { get; set; }
        public virtual ICollection<ZnodeCaseRequest> ZnodeCaseRequests { get; set; }
        public virtual ICollection<ZnodeCMSPortalMessage> ZnodeCMSPortalMessages { get; set; }
        public virtual ICollection<ZnodeCMSPortalMessageKeyTag> ZnodeCMSPortalMessageKeyTags { get; set; }
        public virtual ICollection<ZnodeCMSPortalProductPage> ZnodeCMSPortalProductPages { get; set; }
        public virtual ICollection<ZnodeCMSPortalSEOSetting> ZnodeCMSPortalSEOSettings { get; set; }
        public virtual ICollection<ZnodeCMSPortalTheme> ZnodeCMSPortalThemes { get; set; }
        public virtual ICollection<ZnodeCMSUrlRedirect> ZnodeCMSUrlRedirects { get; set; }
        public virtual ICollection<ZnodeDomain> ZnodeDomains { get; set; }
        public virtual ICollection<ZnodeFormBuilderSubmit> ZnodeFormBuilderSubmits { get; set; }
        public virtual ZnodeOmsOrderState ZnodeOmsOrderState { get; set; }
        public virtual ICollection<ZnodePortalProfile> ZnodePortalProfiles { get; set; }
        public virtual ICollection<ZnodePortalAccount> ZnodePortalAccounts { get; set; }
        public virtual ICollection<ZnodePortalAddress> ZnodePortalAddresses { get; set; }
        public virtual ICollection<ZnodePortalCatalog> ZnodePortalCatalogs { get; set; }
        public virtual ICollection<ZnodePortalCustomCss> ZnodePortalCustomCsses { get; set; }
        public virtual ICollection<ZnodePortalFeatureMapper> ZnodePortalFeatureMappers { get; set; }
        public virtual ICollection<ZnodePortalLocale> ZnodePortalLocales { get; set; }
        public virtual ICollection<ZnodePortalLoginProvider> ZnodePortalLoginProviders { get; set; }
        public virtual ICollection<ZnodePortalPageSetting> ZnodePortalPageSettings { get; set; }
        public virtual ICollection<ZnodePortalPaymentSetting> ZnodePortalPaymentSettings { get; set; }
        public virtual ICollection<ZnodePortalSearchProfile> ZnodePortalSearchProfiles { get; set; }
        public virtual ICollection<ZnodePortalShipping> ZnodePortalShippings { get; set; }
        public virtual ICollection<ZnodePortalShippingDetail> ZnodePortalShippingDetails { get; set; }
        public virtual ICollection<ZnodePortalSortSetting> ZnodePortalSortSettings { get; set; }
        public virtual ICollection<ZnodePortalTaxClass> ZnodePortalTaxClasses { get; set; }
        public virtual ICollection<ZnodePortalUnit> ZnodePortalUnits { get; set; }
        public virtual ICollection<ZnodePortalWarehouse> ZnodePortalWarehouses { get; set; }
        public virtual ICollection<ZnodePriceListPortal> ZnodePriceListPortals { get; set; }
        public virtual ICollection<ZnodeRobotsTxt> ZnodeRobotsTxts { get; set; }
        public virtual ICollection<ZnodeShippingPortal> ZnodeShippingPortals { get; set; }
        public virtual ICollection<ZnodePortalSmtpSetting> ZnodePortalSmtpSettings { get; set; }
        public virtual ICollection<ZnodeTaxPortal> ZnodeTaxPortals { get; set; }
        public virtual ICollection<ZnodeTaxRuleType> ZnodeTaxRuleTypes { get; set; }
        public virtual ICollection<ZnodeUserPortal> ZnodeUserPortals { get; set; }
        public virtual ICollection<ZnodeImpersonationLog> ZnodeImpersonationLogs { get; set; }
        public virtual ICollection<ZnodeSalesRepCustomerUserPortal> ZnodeSalesRepCustomerUserPortals { get; set; }
        public virtual ICollection<ZnodePortalRecommendationSetting> ZnodePortalRecommendationSettings { get; set; }
        public virtual ICollection<ZnodePortalBrand> ZnodePortalBrands { get; set; }
        public virtual ICollection<ZnodeSearchActivity> ZnodeSearchActivities { get; set; }
        public virtual ICollection<ZnodeGoogleTagManager> ZnodeGoogleTagManagers { get; set; }
        public virtual ICollection<ZnodeRmaReturnDetail> ZnodeRmaReturnDetails { get; set; }
        public virtual ICollection<ZnodePortalKlaviyoSetting> ZnodePortalKlaviyoSettings { get; set; }
        public virtual ICollection<ZnodeProductFeed> ZnodeProductFeeds { get; set; }
    }
}
