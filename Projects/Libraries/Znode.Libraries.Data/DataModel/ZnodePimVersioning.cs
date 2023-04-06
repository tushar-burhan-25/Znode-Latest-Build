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
    
    public partial class ZnodePimVersioning : ZnodeEntityBaseModel
    {
        public int ZnodePimVersioningId { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<int> PimCatalogId { get; set; }
        public Nullable<bool> IsPublish { get; set; }
        public Nullable<bool> IsDraft { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<System.DateTime> DraftDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodePimCatalog ZnodePimCatalog { get; set; }
    }
}