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
    
    public partial class ZnodeEmailTemplateMapper : ZnodeEntityBaseModel
    {
        public int EmailTemplateMapperId { get; set; }
        public int EmailTemplateId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public int EmailTemplateAreasId { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsEnableBcc { get; set; }
        public bool IsSmsNotificationActive { get; set; }
    
        public virtual ZnodeEmailTemplate ZnodeEmailTemplate { get; set; }
        public virtual ZnodeEmailTemplateArea ZnodeEmailTemplateArea { get; set; }
    }
}
