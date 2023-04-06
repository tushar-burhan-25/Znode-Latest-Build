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
    
    public partial class ZnodePublishSeoEntity : ZnodeEntityBaseModel
    {
        public int PublishSeoEntityId { get; set; }
        public int VersionId { get; set; }
        public Nullable<System.DateTime> PublishStartTime { get; set; }
        public string ItemName { get; set; }
        public int CMSSEODetailId { get; set; }
        public int CMSSEODetailLocaleId { get; set; }
        public int CMSSEOTypeId { get; set; }
        public Nullable<int> SEOId { get; set; }
        public string SEOTypeName { get; set; }
        public string SEOTitle { get; set; }
        public string SEODescription { get; set; }
        public string SEOKeywords { get; set; }
        public string SEOUrl { get; set; }
        public Nullable<bool> IsRedirect { get; set; }
        public string MetaInformation { get; set; }
        public Nullable<int> LocaleId { get; set; }
        public string OldSEOURL { get; set; }
        public int CMSContentPagesId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public string SEOCode { get; set; }
        public string CanonicalURL { get; set; }
        public string RobotTag { get; set; }
    }
}