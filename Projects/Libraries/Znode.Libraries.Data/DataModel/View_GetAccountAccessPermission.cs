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
    
    public partial class View_GetAccountAccessPermission : ZnodeEntityBaseModel
    {
        public int AccountPermissionId { get; set; }
        public int AccountId { get; set; }
        public string AccountPermissionName { get; set; }
        public string PermissionsName { get; set; }
        public Nullable<int> AccountPermissionAccessId { get; set; }
        public string PermissionCode { get; set; }
        public Nullable<int> AccessPermissionId { get; set; }
    }
}
