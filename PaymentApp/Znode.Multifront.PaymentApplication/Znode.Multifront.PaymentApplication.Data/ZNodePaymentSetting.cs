//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Multifront.PaymentApplication.Data
{
    using System;
    using System.Collections.Generic;
     using Znode.Multifront.PaymentApplication.Models;
    public partial class ZNodePaymentSetting : ZnodePaymentEntityBaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZNodePaymentSetting()
        {
            this.ZnodeTransactions = new HashSet<ZnodeTransaction>();
            this.ZNodePaymentSettingCredentials = new HashSet<ZNodePaymentSettingCredential>();
            this.ZnodePaymentMethods = new HashSet<ZnodePaymentMethod>();
        }
    
        public int PaymentSettingId { get; set; }
        public int PaymentTypeId { get; set; }
        public Nullable<int> PaymentGatewayId { get; set; }
        public Nullable<bool> EnableVisa { get; set; }
        public Nullable<bool> EnableMasterCard { get; set; }
        public Nullable<bool> EnableAmex { get; set; }
        public Nullable<bool> EnableDiscover { get; set; }
        public Nullable<bool> EnableRecurringPayments { get; set; }
        public Nullable<bool> EnableVault { get; set; }
        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }
        public bool PreAuthorize { get; set; }
        public Nullable<bool> IsRMACompatible { get; set; }
        public bool TestMode { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool EnablePODocUpload { get; set; }
        public bool IsPODocRequired { get; set; }
        public string PaymentCode { get; set; }
    
        public virtual ZNodePaymentGateway ZNodePaymentGateway { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZnodeTransaction> ZnodeTransactions { get; set; }
        public virtual ZNodePaymentType ZNodePaymentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZNodePaymentSettingCredential> ZNodePaymentSettingCredentials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZnodePaymentMethod> ZnodePaymentMethods { get; set; }
    }
}
