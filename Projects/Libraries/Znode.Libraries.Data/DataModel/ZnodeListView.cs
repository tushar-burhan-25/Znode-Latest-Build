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
    
    public partial class ZnodeListView : ZnodeEntityBaseModel
    {
        public ZnodeListView()
        {
            this.ZnodeListViewFilters = new HashSet<ZnodeListViewFilter>();
        }
    
        public int ListViewId { get; set; }
        public Nullable<int> ApplicationSettingId { get; set; }
        public string ViewName { get; set; }
        public string XmlSetting { get; set; }
        public bool IsSelected { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string SortColumn { get; set; }
        public string SortType { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual ZnodeApplicationSetting ZnodeApplicationSetting { get; set; }
        public virtual ICollection<ZnodeListViewFilter> ZnodeListViewFilters { get; set; }
    }
}