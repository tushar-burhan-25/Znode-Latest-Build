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
    
    public partial class ZnodePimAddonGroup : ZnodeEntityBaseModel
    {
        public ZnodePimAddonGroup()
        {
            this.ZnodePimAddOnProducts = new HashSet<ZnodePimAddOnProduct>();
            this.ZnodePimAddonGroupLocales = new HashSet<ZnodePimAddonGroupLocale>();
            this.ZnodePimAddonGroupProducts = new HashSet<ZnodePimAddonGroupProduct>();
        }
    
        public int PimAddonGroupId { get; set; }
        public string DisplayType { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodePimAddOnProduct> ZnodePimAddOnProducts { get; set; }
        public virtual ICollection<ZnodePimAddonGroupLocale> ZnodePimAddonGroupLocales { get; set; }
        public virtual ICollection<ZnodePimAddonGroupProduct> ZnodePimAddonGroupProducts { get; set; }
    }
}
