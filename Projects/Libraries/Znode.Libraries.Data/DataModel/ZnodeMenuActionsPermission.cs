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
    
    public partial class ZnodeMenuActionsPermission : ZnodeEntityBaseModel
    {
        public int MenuActionsPermissionId { get; set; }
        public int MenuId { get; set; }
        public int ActionId { get; set; }
        public int AccessPermissionId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeAccessPermission ZnodeAccessPermission { get; set; }
        public virtual ZnodeAction ZnodeAction { get; set; }
        public virtual ZnodeMenu ZnodeMenu { get; set; }
    }
}
