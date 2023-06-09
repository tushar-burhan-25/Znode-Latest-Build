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
    
    public partial class ZnodeMediaPath : ZnodeEntityBaseModel
    {
        public ZnodeMediaPath()
        {
            this.ZnodeMediaCategories = new HashSet<ZnodeMediaCategory>();
            this.ZnodeMediaFolderUsers = new HashSet<ZnodeMediaFolderUser>();
            this.ZnodeMediaPath1 = new HashSet<ZnodeMediaPath>();
            this.ZnodeMediaPathLocales = new HashSet<ZnodeMediaPathLocale>();
        }
    
        public int MediaPathId { get; set; }
        public Nullable<int> ParentMediaPathId { get; set; }
        public string PathCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeMediaCategory> ZnodeMediaCategories { get; set; }
        public virtual ICollection<ZnodeMediaFolderUser> ZnodeMediaFolderUsers { get; set; }
        public virtual ICollection<ZnodeMediaPath> ZnodeMediaPath1 { get; set; }
        public virtual ZnodeMediaPath ZnodeMediaPath2 { get; set; }
        public virtual ICollection<ZnodeMediaPathLocale> ZnodeMediaPathLocales { get; set; }
    }
}
