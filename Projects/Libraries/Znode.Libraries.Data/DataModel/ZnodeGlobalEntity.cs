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
    
    public partial class ZnodeGlobalEntity : ZnodeEntityBaseModel
    {
        public ZnodeGlobalEntity()
        {
            this.ZnodeGlobalAttributes = new HashSet<ZnodeGlobalAttribute>();
            this.ZnodeGlobalAttributeFamilies = new HashSet<ZnodeGlobalAttributeFamily>();
            this.ZnodeGlobalAttributeGroups = new HashSet<ZnodeGlobalAttributeGroup>();
            this.ZnodeGlobalAttributeValues = new HashSet<ZnodeGlobalAttributeValue>();
            this.ZnodeGlobalEntityFamilyMappers = new HashSet<ZnodeGlobalEntityFamilyMapper>();
            this.ZnodeGlobalGroupEntityMappers = new HashSet<ZnodeGlobalGroupEntityMapper>();
        }
    
        public int GlobalEntityId { get; set; }
        public string EntityName { get; set; }
        public bool IsActive { get; set; }
        public string TableName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsFamilyUnique { get; set; }
    
        public virtual ICollection<ZnodeGlobalAttribute> ZnodeGlobalAttributes { get; set; }
        public virtual ICollection<ZnodeGlobalAttributeFamily> ZnodeGlobalAttributeFamilies { get; set; }
        public virtual ICollection<ZnodeGlobalAttributeGroup> ZnodeGlobalAttributeGroups { get; set; }
        public virtual ICollection<ZnodeGlobalAttributeValue> ZnodeGlobalAttributeValues { get; set; }
        public virtual ICollection<ZnodeGlobalEntityFamilyMapper> ZnodeGlobalEntityFamilyMappers { get; set; }
        public virtual ICollection<ZnodeGlobalGroupEntityMapper> ZnodeGlobalGroupEntityMappers { get; set; }
    }
}