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
    
    public partial class ZnodeApplicationSetting : ZnodeEntityBaseModel
    {
        public ZnodeApplicationSetting()
        {
            this.ZnodeListViews = new HashSet<ZnodeListView>();
        }
    
        public int ApplicationSettingId { get; set; }
        public string GroupName { get; set; }
        public string ItemName { get; set; }
        public string Setting { get; set; }
        public string ViewOptions { get; set; }
        public string FrontPageName { get; set; }
        public string FrontObjectName { get; set; }
        public bool IsCompressed { get; set; }
        public string OrderByFields { get; set; }
        public string ItemNameWithoutCurrency { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeListView> ZnodeListViews { get; set; }
    }
}