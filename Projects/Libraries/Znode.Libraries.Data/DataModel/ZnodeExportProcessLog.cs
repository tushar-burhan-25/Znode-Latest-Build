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
    
    public partial class ZnodeExportProcessLog : ZnodeEntityBaseModel
    {
        public int ExportProcessLogId { get; set; }
        public string ExportType { get; set; }
        public string FileType { get; set; }
        public string Status { get; set; }
        public System.DateTime ProcessStartedDate { get; set; }
        public Nullable<System.DateTime> ProcessCompletedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string TableName { get; set; }
    }
}