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
    
    public partial class ZnodeActivityLog : ZnodeEntityBaseModel
    {
        public int ActivityLogId { get; set; }
        public int ActivityLogTypeId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public System.DateTime ActivityCreateDate { get; set; }
        public Nullable<System.DateTime> ActivityEndDate { get; set; }
        public string URL { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
        public string Data3 { get; set; }
        public string Status { get; set; }
        public string LongData { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodePortal ZnodePortal { get; set; }
    }
}
