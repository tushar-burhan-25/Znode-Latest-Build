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
    
    public partial class ZnodeImportLog : ZnodeEntityBaseModel
    {
        public int ImportLogId { get; set; }
        public int ImportProcessLogId { get; set; }
        public string ErrorDescription { get; set; }
        public string ColumnName { get; set; }
        public string Data { get; set; }
        public string DefaultErrorValue { get; set; }
        public Nullable<long> RowNumber { get; set; }
        public string Guid { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeImportProcessLog ZnodeImportProcessLog { get; set; }
    }
}