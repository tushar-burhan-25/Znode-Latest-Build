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
    
    public partial class ZnodeCMSPortalMessageKeyTag : ZnodeEntityBaseModel
    {
        public int CMSPortalMessageKeyTagId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public Nullable<int> CMSMessageKeyId { get; set; }
        public string TagXML { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ZnodeCMSMessageKey ZnodeCMSMessageKey { get; set; }
        public virtual ZnodePortal ZnodePortal { get; set; }
    }
}
