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
    
    public partial class ZnodePageSetting : ZnodeEntityBaseModel
    {
        public ZnodePageSetting()
        {
            this.ZnodePortalPageSettings = new HashSet<ZnodePortalPageSetting>();
        }
    
        public int PageSettingId { get; set; }
        public string PageName { get; set; }
        public int PageValue { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodePortalPageSetting> ZnodePortalPageSettings { get; set; }
    }
}
