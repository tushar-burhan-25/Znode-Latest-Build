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
    
    public partial class ZnodeCMSMediaConfiguration : ZnodeEntityBaseModel
    {
        public int CMSMediaConfigurationId { get; set; }
        public Nullable<int> CMSWidgetsId { get; set; }
        public string WidgetsKey { get; set; }
        public Nullable<int> CMSMappingId { get; set; }
        public string TypeOFMapping { get; set; }
        public Nullable<int> MediaId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ZnodeMedia ZnodeMedia { get; set; }
        public virtual ZnodeCMSWidget ZnodeCMSWidget { get; set; }
    }
}