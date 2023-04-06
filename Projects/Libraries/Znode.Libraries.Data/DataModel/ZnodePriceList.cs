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
    
    public partial class ZnodePriceList : ZnodeEntityBaseModel
    {
        public ZnodePriceList()
        {
            this.ZnodePrices = new HashSet<ZnodePrice>();
            this.ZnodePriceListUsers = new HashSet<ZnodePriceListUser>();
            this.ZnodePriceListAccounts = new HashSet<ZnodePriceListAccount>();
            this.ZnodePriceListAddresses = new HashSet<ZnodePriceListAddress>();
            this.ZnodePriceListDiscounts = new HashSet<ZnodePriceListDiscount>();
            this.ZnodePriceListPortals = new HashSet<ZnodePriceListPortal>();
            this.ZnodePriceListProfiles = new HashSet<ZnodePriceListProfile>();
            this.ZnodePriceTiers = new HashSet<ZnodePriceTier>();
        }
    
        public int PriceListId { get; set; }
        public string ListCode { get; set; }
        public string ListName { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> CultureId { get; set; }
    
        public virtual ZnodeCulture ZnodeCulture { get; set; }
        public virtual ZnodeCurrency ZnodeCurrency { get; set; }
        public virtual ICollection<ZnodePrice> ZnodePrices { get; set; }
        public virtual ICollection<ZnodePriceListUser> ZnodePriceListUsers { get; set; }
        public virtual ICollection<ZnodePriceListAccount> ZnodePriceListAccounts { get; set; }
        public virtual ICollection<ZnodePriceListAddress> ZnodePriceListAddresses { get; set; }
        public virtual ICollection<ZnodePriceListDiscount> ZnodePriceListDiscounts { get; set; }
        public virtual ICollection<ZnodePriceListPortal> ZnodePriceListPortals { get; set; }
        public virtual ICollection<ZnodePriceListProfile> ZnodePriceListProfiles { get; set; }
        public virtual ICollection<ZnodePriceTier> ZnodePriceTiers { get; set; }
    }
}
