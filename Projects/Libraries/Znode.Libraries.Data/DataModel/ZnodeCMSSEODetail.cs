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
    
    public partial class ZnodeCMSSEODetail : ZnodeEntityBaseModel
    {
        public ZnodeCMSSEODetail()
        {
            this.ZnodeCMSSEODetailLocales = new HashSet<ZnodeCMSSEODetailLocale>();
        }
    
        public int CMSSEODetailId { get; set; }
        public int CMSSEOTypeId { get; set; }
        public Nullable<int> SEOId { get; set; }
        public Nullable<bool> IsRedirect { get; set; }
        public string MetaInformation { get; set; }
        public Nullable<int> PortalId { get; set; }
        public string SEOUrl { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsPublish { get; set; }
        public string SEOCode { get; set; }
        public byte PublishStateId { get; set; }
    
        public virtual ZnodePublishState ZnodePublishState { get; set; }
        public virtual ZnodeCMSSEOType ZnodeCMSSEOType { get; set; }
        public virtual ICollection<ZnodeCMSSEODetailLocale> ZnodeCMSSEODetailLocales { get; set; }
    }
}