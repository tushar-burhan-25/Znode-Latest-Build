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
    
    public partial class ZnodeTimeFormat : ZnodeEntityBaseModel
    {
        public int TimeFormatId { get; set; }
        public string TimeFormat { get; set; }
        public Nullable<int> ConversionFactor { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> MSSqlConvertId { get; set; }
        public string CultureName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
