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
    
    public partial class View_CustomerUserDetail : ZnodeEntityBaseModel
    {
        public int userId { get; set; }
        public string AspNetuserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool EmailOptIn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsLock { get; set; }
        public string FullName { get; set; }
        public string AccountName { get; set; }
        public string PermissionsName { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> AccountPermissionAccessId { get; set; }
        public string ExternalId { get; set; }
        public int IsAccountCustomer { get; set; }
        public Nullable<decimal> BudgetAmount { get; set; }
        public Nullable<int> AccountUserOrderApprovalId { get; set; }
        public string ApprovalName { get; set; }
        public Nullable<int> ApprovalUserId { get; set; }
        public string PermissionCode { get; set; }
        public Nullable<int> PortalId { get; set; }
        public string TypeOfRole { get; set; }
        public int IsGuestUser { get; set; }
        public string CustomerPaymentGUID { get; set; }
        public string StoreName { get; set; }
    }
}
