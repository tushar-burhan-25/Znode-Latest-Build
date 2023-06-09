﻿using System;
using System.Collections.Generic;

namespace Znode.Engine.Api.Models
{
    public class PlaceOrderLineItemModel : BaseModel
    {
        public int OmsOrderLineItemsId { get; set; }
        public int OmsOrderDetailsId { get; set; }
        public int OmsOrderShipmentId { get; set; }
        public string Sku { get; set; }

        //This property is used for product customization
        public string GroupId { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Weight { get; set; }
        public string DownloadLink { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool? ShipSeparately { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? ShippingCost { get; set; }
        public string PromoDescription { get; set; }
        public string TransactionNumber { get; set; }
        public int? PaymentStatusId { get; set; }
        public string TrackingNumber { get; set; }
        public bool? IsAutoGeneratedTracking { get; set; }
        public int? OrderLineItemStateId { get; set; }
        public bool? IsRecurringBilling { get; set; }
        public string RecurringBillingPeriod { get; set; }
        public int? RecurringBillingCycles { get; set; }
        public string RecurringBillingFrequency { get; set; }
        public decimal? RecurringBillingAmount { get; set; }
        public string AppliedPromo { get; set; }
        public string CouponsApplied { get; set; }
        public string ExternalId { get; set; }
        public int? OrderLineItemRelationshipTypeId { get; set; }
        public string AutoAddonSku { get; set; }
        public int? RmaReasonForReturnId { get; set; }
        public decimal? PartialRefundAmount { get; set; }
        public bool IsShippingReturn { get; set; }
        public List<PlaceOrderPersonaliseModel> PersonaliseDetails { get; set; }
        public int BundleQuantity { get; set; }
        public List<PlaceOrderlineItemCollection> OrderLineItem { get; set; }
        public decimal SalesTax { get; set; }
        public decimal VAT { get; set; }
        public decimal GST { get; set; }
        public decimal PST { get; set; }
        public decimal HST { get; set; }
        public decimal ImportDuty { get; set; }
        public string TaxTransactionNumber { get; set; }
        public int TaxRuleId { get; set; }
        public List<AdditionalCost> AdditionalCostList { get; set; }
        public int GroupIdentifier { get; set; }

    }
    public class AdditionalCost
    {
        public string KeyName { get; set; }
        public decimal KeyValue { get; set; }

    }
}
