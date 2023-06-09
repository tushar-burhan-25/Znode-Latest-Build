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
    
    public partial class ZnodeCMSWidgetTitleConfiguration : ZnodeEntityBaseModel
    {
        public ZnodeCMSWidgetTitleConfiguration()
        {
            this.ZnodeCMSWidgetTitleConfigurationLocales = new HashSet<ZnodeCMSWidgetTitleConfigurationLocale>();
        }
    
        public int CMSWidgetTitleConfigurationId { get; set; }
        public string TitleCode { get; set; }
        public int CMSWidgetsId { get; set; }
        public string WidgetsKey { get; set; }
        public int CMSMappingId { get; set; }
        public string TypeOFMapping { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeCMSWidget ZnodeCMSWidget { get; set; }
        public virtual ICollection<ZnodeCMSWidgetTitleConfigurationLocale> ZnodeCMSWidgetTitleConfigurationLocales { get; set; }
    }
}
