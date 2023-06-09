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
    
    public partial class ZnodePublishPortalLog : ZnodeEntityBaseModel
    {
        public int PublishPortalLogId { get; set; }
        public int PortalId { get; set; }
        public Nullable<bool> IsPortalPublished { get; set; }
        public string PublishCategoryId { get; set; }
        public Nullable<bool> IsCategoryPublished { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> LogDateTime { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Token { get; set; }
        public byte PublishStateId { get; set; }
    
        public virtual ZnodePublishState ZnodePublishState { get; set; }
    }
}
