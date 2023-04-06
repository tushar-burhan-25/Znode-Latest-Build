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
    
    public partial class ZnodeECertificate : ZnodeEntityBaseModel
    {
        public ZnodeECertificate()
        {
            this.ZnodeECertificateWallets = new HashSet<ZnodeECertificateWallet>();
        }
    
        public int ECertificateId { get; set; }
        public string CertificateKey { get; set; }
        public string CertificateType { get; set; }
        public Nullable<System.DateTime> IssuedDate { get; set; }
        public decimal IssuedAmount { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ZnodeECertificateWallet> ZnodeECertificateWallets { get; set; }
    }
}
