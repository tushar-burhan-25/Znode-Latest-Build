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
    
    public partial class ZnodePortalSmsSetting : ZnodeEntityBaseModel
    {
        public int PortalSmsSettingId { get; set; }
        public int PortalId { get; set; }
        public int SmsProviderId { get; set; }
        public string SmsPortalAccountId { get; set; }
        public string AuthToken { get; set; }
        public string FromMobileNumber { get; set; }
        public bool IsSMSSettingEnabled { get; set; }
    
        public virtual ZnodeSmsProvider ZnodeSmsProvider { get; set; }
    }
}
