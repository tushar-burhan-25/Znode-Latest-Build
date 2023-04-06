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
    
    public partial class ZnodeCMSPortalTheme : ZnodeEntityBaseModel
    {
        public int CMSPortalThemeId { get; set; }
        public int PortalId { get; set; }
        public int CMSThemeId { get; set; }
        public Nullable<int> CMSThemeCSSId { get; set; }
        public Nullable<int> MediaId { get; set; }
        public Nullable<int> FavIconId { get; set; }
        public string WebsiteTitle { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string WebsiteDescription { get; set; }
    
        public virtual ZnodeCMSTheme ZnodeCMSTheme { get; set; }
        public virtual ZnodeCMSThemeCSS ZnodeCMSThemeCSS { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
    }
}
