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
    
    public partial class ZnodeShipping : ZnodeEntityBaseModel
    {
        public ZnodeShipping()
        {
            this.ZnodeOmsOrderShipments = new HashSet<ZnodeOmsOrderShipment>();
            this.ZnodePromotionShippings = new HashSet<ZnodePromotionShipping>();
            this.ZnodeShippingRules = new HashSet<ZnodeShippingRule>();
            this.ZnodeOmsQuotes = new HashSet<ZnodeOmsQuote>();
            this.ZnodePortalShippings = new HashSet<ZnodePortalShipping>();
            this.ZnodeProfileShippings = new HashSet<ZnodeProfileShipping>();
            this.ZnodeOmsOrderDetails = new HashSet<ZnodeOmsOrderDetail>();
        }
    
        public int ShippingId { get; set; }
        public int ShippingTypeId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public string ShippingCode { get; set; }
        public string ShippingName { get; set; }
        public decimal HandlingCharge { get; set; }
        public string HandlingChargeBasedOn { get; set; }
        public string DestinationCountryCode { get; set; }
        public string StateCode { get; set; }
        public string CountyFIPS { get; set; }
        public string TrackingUrl { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }
        public string ZipCode { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string DeliveryTimeframe { get; set; }
        public Nullable<int> CultureId { get; set; }
    
        public virtual ZnodeCurrency ZnodeCurrency { get; set; }
        public virtual ICollection<ZnodeOmsOrderShipment> ZnodeOmsOrderShipments { get; set; }
        public virtual ICollection<ZnodePromotionShipping> ZnodePromotionShippings { get; set; }
        public virtual ICollection<ZnodeShippingRule> ZnodeShippingRules { get; set; }
        public virtual ZnodeShippingType ZnodeShippingType { get; set; }
        public virtual ZnodeCulture ZnodeCulture { get; set; }
        public virtual ICollection<ZnodeOmsQuote> ZnodeOmsQuotes { get; set; }
        public virtual ICollection<ZnodePortalShipping> ZnodePortalShippings { get; set; }
        public virtual ICollection<ZnodeProfileShipping> ZnodeProfileShippings { get; set; }
        public virtual ICollection<ZnodeOmsOrderDetail> ZnodeOmsOrderDetails { get; set; }
    }
}
