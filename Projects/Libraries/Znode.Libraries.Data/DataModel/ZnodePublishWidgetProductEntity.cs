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
    
    public partial class ZnodePublishWidgetProductEntity : ZnodeEntityBaseModel
    {
        public int PublishWidgetProductEntityId { get; set; }
        public int VersionId { get; set; }
        public Nullable<System.DateTime> PublishStartTime { get; set; }
        public int WidgetProductId { get; set; }
        public int ZnodeProductId { get; set; }
        public int PortalId { get; set; }
        public int MappingId { get; set; }
        public string WidgetsKey { get; set; }
        public string TypeOFMapping { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string SKU { get; set; }
    }
}
