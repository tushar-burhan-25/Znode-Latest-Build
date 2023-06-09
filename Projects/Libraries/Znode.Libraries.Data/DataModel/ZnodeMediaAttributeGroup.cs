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
    
    public partial class ZnodeMediaAttributeGroup : ZnodeEntityBaseModel
    {
        public ZnodeMediaAttributeGroup()
        {
            this.ZnodeMediaAttributeGroupLocales = new HashSet<ZnodeMediaAttributeGroupLocale>();
            this.ZnodeMediaAttributeGroupMappers = new HashSet<ZnodeMediaAttributeGroupMapper>();
            this.ZnodeMediaFamilyGroupMappers = new HashSet<ZnodeMediaFamilyGroupMapper>();
        }
    
        public int MediaAttributeGroupId { get; set; }
        public string GroupCode { get; set; }
        public bool IsSystemDefined { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public bool IsHidden { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeMediaAttributeGroupLocale> ZnodeMediaAttributeGroupLocales { get; set; }
        public virtual ICollection<ZnodeMediaAttributeGroupMapper> ZnodeMediaAttributeGroupMappers { get; set; }
        public virtual ICollection<ZnodeMediaFamilyGroupMapper> ZnodeMediaFamilyGroupMappers { get; set; }
    }
}
