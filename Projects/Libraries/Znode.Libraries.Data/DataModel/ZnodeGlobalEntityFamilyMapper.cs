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
    
    public partial class ZnodeGlobalEntityFamilyMapper : ZnodeEntityBaseModel
    {
        public int GlobalEntityFamilyMapperId { get; set; }
        public int GlobalAttributeFamilyId { get; set; }
        public int GlobalEntityId { get; set; }
        public Nullable<int> GlobalEntityValueId { get; set; }
    
        public virtual ZnodeGlobalAttributeFamily ZnodeGlobalAttributeFamily { get; set; }
        public virtual ZnodeGlobalEntity ZnodeGlobalEntity { get; set; }
    }
}
