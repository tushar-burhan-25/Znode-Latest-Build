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
    
    public partial class ZnodePublishProgressNotifierEntity : ZnodeEntityBaseModel
    {
        public int PublishProgressNotifierEntityId { get; set; }
        public int VersionId { get; set; }
        public string JobId { get; set; }
        public string JobName { get; set; }
        public int ProgressMark { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsFailed { get; set; }
        public string ExceptionMessage { get; set; }
        public int StartedBy { get; set; }
        public string StartedByFriendlyName { get; set; }
    }
}