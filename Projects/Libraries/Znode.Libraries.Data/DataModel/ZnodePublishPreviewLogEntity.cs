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
    
    public partial class ZnodePublishPreviewLogEntity : ZnodeEntityBaseModel
    {
        public int PublishPreviewLogEntityId { get; set; }
        public Nullable<int> VersionId { get; set; }
        public Nullable<System.DateTime> PublishStartTime { get; set; }
        public Nullable<bool> IsDisposed { get; set; }
        public string SourcePublishState { get; set; }
        public Nullable<int> EntityId { get; set; }
        public string EntityType { get; set; }
        public string LogMessage { get; set; }
        public Nullable<System.DateTime> LogCreatedDate { get; set; }
        public Nullable<int> PreviousVersionId { get; set; }
        public Nullable<int> LocaleId { get; set; }
        public string LocaleDisplayValue { get; set; }
    }
}