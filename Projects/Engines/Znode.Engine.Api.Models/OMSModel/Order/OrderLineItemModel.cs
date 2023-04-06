﻿using System;
using System.Collections.Generic;

namespace Znode.Engine.Api.Models
{
    public class OrderLineItemModel : BaseModel
    {
        public OrderLineItemModel()
        {
            OrderLineItemCollection = new List<OrderLineItemModel>();
        }

        public int OmsOrderLineItemsId { get; set; }
        public int OmsOrderDetailsId { get; set; }
        public int OmsOrderShipmentId { get; set; }
        public string Sku { get; set; }
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
        public bool IsActive { get; set; }
        public int? ParentOmsOrderLineItemsId { get; set; }
        public int? OrderLineItemRelationshipTypeId { get; set; }
        public OrderShipmentModel ZnodeOmsOrderShipment { get; set; }
        public List<OrderLineItemModel> OrderLineItemCollection { get; set; }
        public List<OrderDiscountModel> OrdersDiscount { get; set; }
        public List<OrderWarehouseModel> OrderWarehouse { get; set; }
        public Dictionary<string, object> PersonaliseValueList { get; set; }
        public List<PersonaliseValueModel> PersonaliseValuesDetail { get; set; }
        public List<OrderAttributeModel> Attributes { get; set; }
        public string ShippingAddressHtml { get; set; }

        public decimal SalesTax { get; set; }
        public decimal VAT { get; set; }
        public decimal GST { get; set; }
        public decimal PST { get; set; }
        public decimal HST { get; set; }
        public decimal ImportDuty { get; set; }
        public decimal Total { get; set; }
        public string GroupProductQuantity { get; set; }
        public string GroupProductPrice { get; set; }
        public string Vendor { get; set; }
        public string TaxTransactionNumber { get; set; }
        public string AutoAddonSku { get; set; }
        public int TaxRuleId { get; set; }
        public bool IsLineItemShippingCostEdited { get; set; }
        public bool IsLineItemTaxCostEdited { get; set; }
        public int? RmaReasonForReturnId { get; set; }
        public string OrderLineItemState { get; set; }
        public bool IsItemStateChanged { get; set; }
        public bool IsShowToCustomer { get; set; }
        public decimal? PartialRefundAmount { get; set; }
        public string DownloadableProductKey { get; set; }

        public bool IsShippingReturn { get; set; }

        public string GroupId { get; set; }

        public string ProductImagePath { get; set; }
        public Dictionary<string, decimal> AdditionalCost { get; set; }
        public bool IsDownloadableSKU { get; set; }
        public string ParentProductSKU { get; set; }
        public bool IsConfigurableProduct { get; set; }
        public string ProductType { get; set; }
        public decimal LineItemOrderDiscountAmount { get; set; }
        public decimal? ProductLevelTax { get; set; }
        public string InventoryTracking { get; set; }
        public int BundleQuantity { get; set; }
    }
}