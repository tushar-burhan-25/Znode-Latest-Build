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
    
    public partial class ZnodePublishPortalCustomCssEntity : ZnodeEntityBaseModel
    {
        public int PublishPortalCustomCssEntityId { get; set; }
        public int VersionId { get; set; }
        public Nullable<System.DateTime> PublishStartTime { get; set; }
        public int PortalId { get; set; }
        public string DynamicStyle { get; set; }
        public string PublishState { get; set; }
        public int LocaleId { get; set; }
    }
}
