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
    
    public partial class View_CMSWidgetsConfigurationList : ZnodeEntityBaseModel
    {
        public int CMSWidgetTitleConfigurationLocaleId { get; set; }
        public Nullable<int> CMSWidgetTitleConfigurationId { get; set; }
        public Nullable<int> CMSMappingId { get; set; }
        public Nullable<int> cmsWidgetsId { get; set; }
        public string WidgetsKey { get; set; }
        public string TypeOFMapping { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int LocaleId { get; set; }
        public string TitleCode { get; set; }
        public Nullable<int> MediaId { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
    }
}