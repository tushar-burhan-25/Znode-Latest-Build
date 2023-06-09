﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Contains Level Three transaction data.
    /// </summary>
    public class LevelThreeData
    {
        #region Properties

        [JsonProperty("products")]
        public List<Product> Products { get; set; }

        //TODO - Missing from API DOCs Reference Page
        //public VatData VatData { get; set;}

        /// <summary>
        /// Date of the transaction.
        /// </summary>
        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Destination address of the purchased items.
        /// </summary>
        [JsonProperty("destinationAddress")]
        public Address DestinationAddress { get; set;}

        /// <summary>
        /// Origin address of the purchased items.
        /// </summary>
        [JsonProperty("originAddress")]
        public Address OriginAddress { get; set;}

        /// <summary>
        ///  Amount of discount applied to the purchased items. 
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Plan identifier. Auto-generated by the system and given to the merchant when the plan is added.
        /// </summary>
        [JsonProperty("planId")]
        public int PlanId { get; set; }

        /// <summary>
        ///  Plan start date. 
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Next scheduled payment date.
        /// </summary>
        [JsonProperty("nextPaymentDate")]
        public DateTime NextPaymentDate { get; set; }

        /// <summary>
        /// Number of times to retry billing if payment is declined.
        /// </summary>
        [JsonProperty("maxRetries")]
        public int MaxRetries { get; set; }

        /// <summary>
        /// Primary payment method to be used for billing.
        /// </summary>
        [JsonProperty("primaryPaymentMethodId")]
        public String PrimaryPaymentMethodId { get; set; }

        /// <summary>
        /// Secondary payment method to be used for billing.
        /// </summary>
        [JsonProperty("secondaryPaymentMethodId")]
        public String SecondaryPaymentMethodId { get; set; }

        /// <summary>
        /// Custom user-defined fields tied to the plan, which can be used for reporting.
        /// </summary>
        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        #endregion
    }
}
