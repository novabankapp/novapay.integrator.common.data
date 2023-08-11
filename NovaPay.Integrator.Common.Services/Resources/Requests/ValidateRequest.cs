using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Resources.Requests
{
    public class ValidationRequest
    {
        [JsonPropertyName("service_identifier")]
        [JsonProperty("service_identifier")]
        public string? ServiceIdentifier { get; set; }

        [JsonPropertyName("reference")]
        [JsonProperty("reference")]
        public string? Reference { get; set; }


    }
}
