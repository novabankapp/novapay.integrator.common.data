﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Resources.Requests
{
    public class ProductTransactionRequest
    {
        [JsonPropertyName("prn")]
        [JsonProperty("prn")]
        public string? PRN { get; set; }
        [JsonPropertyName("service_name")]
        [JsonProperty("service_name")]
        public string? ServiceName { get; set; }

        [JsonPropertyName("service_unique_id")]
        [JsonProperty("service_unique_id")]
        public string? ServiceUniqueId { get; set; }

        [JsonPropertyName("financial_service_unique_id")]
        [JsonProperty("financial_service_unique_id")]
        public string? FinancialServiceUniqueId { get; set; }



        [JsonPropertyName("financial_service_name")]
        [JsonProperty("financial_service_name")]
        public string? FinancialServiceName { get; set; }
        [JsonPropertyName("transaction_ref")]
        [JsonProperty("transaction_ref")]
        public string? TransactionRef { get; set; }

        [JsonPropertyName("product_ref")]
        [JsonProperty("product_ref")]
        public string? ProductRef { get; set; }

        [JsonPropertyName("amount")]
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
        [JsonPropertyName("transaction_date")]
        [JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }
    }
}
