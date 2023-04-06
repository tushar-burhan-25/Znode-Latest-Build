﻿using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class CreateCustomerResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("vaultCustomer")]
        public VaultCustomer VaultCustomer { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        #endregion
    }
}
