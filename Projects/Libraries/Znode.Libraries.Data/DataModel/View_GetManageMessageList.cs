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
    
    public partial class View_GetManageMessageList : ZnodeEntityBaseModel
    {
        public int CMSPortalMessageId { get; set; }
        public int CMSMessageId { get; set; }
        public string Message { get; set; }
        public string Location { get; set; }
        public string StoreName { get; set; }
        public int LocaleId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public int CMSMessageKeyId { get; set; }
        public string MessageTag { get; set; }
        public string StateName { get; set; }
        public Nullable<bool> PublishStatus { get; set; }
        public string IsGlobalContentBlock { get; set; }
    }
}