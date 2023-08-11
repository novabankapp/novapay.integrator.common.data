using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantApiKeyConfigDto : IDTO
    {
        public int RecordId { get; set; }
        public string? ApiSecretKey { get; set; }

        public string? ApiPublishableKey { get; set; }

        public int MerchantConfigRecordId { get; set; }

        public MerchantConfigDto MerchantConfig { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
