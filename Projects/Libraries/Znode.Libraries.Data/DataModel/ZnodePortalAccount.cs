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
    
    public partial class ZnodePortalAccount : ZnodeEntityBaseModel
    {
        public int PortalAccountId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAccount ZnodeAccount { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
    }
}
