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
    
    public partial class ZnodeAddress : ZnodeEntityBaseModel
    {
        public ZnodeAddress()
        {
            this.ZnodeAccountAddresses = new HashSet<ZnodeAccountAddress>();
            this.ZnodeOmsOrderShipments = new HashSet<ZnodeOmsOrderShipment>();
            this.ZnodePimVendors = new HashSet<ZnodePimVendor>();
            this.ZnodePortalAddresses = new HashSet<ZnodePortalAddress>();
            this.ZnodePriceListAddresses = new HashSet<ZnodePriceListAddress>();
            this.ZnodeUserAddresses = new HashSet<ZnodeUserAddress>();
            this.ZnodeWarehouseAddresses = new HashSet<ZnodeWarehouseAddress>();
        }
    
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobilenumber { get; set; }
        public string AlternateMobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public bool IsDefaultBilling { get; set; }
        public bool IsDefaultShipping { get; set; }
        public bool IsActive { get; set; }
        public string ExternalId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsShipping { get; set; }
        public bool IsBilling { get; set; }
        public string EmailAddress { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
    
        public virtual ICollection<ZnodeAccountAddress> ZnodeAccountAddresses { get; set; }
        public virtual ICollection<ZnodeOmsOrderShipment> ZnodeOmsOrderShipments { get; set; }
        public virtual ICollection<ZnodePimVendor> ZnodePimVendors { get; set; }
        public virtual ICollection<ZnodePortalAddress> ZnodePortalAddresses { get; set; }
        public virtual ICollection<ZnodePriceListAddress> ZnodePriceListAddresses { get; set; }
        public virtual ICollection<ZnodeUserAddress> ZnodeUserAddresses { get; set; }
        public virtual ICollection<ZnodeWarehouseAddress> ZnodeWarehouseAddresses { get; set; }
    }
}
