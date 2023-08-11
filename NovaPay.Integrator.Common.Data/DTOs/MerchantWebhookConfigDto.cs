using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantWebhookConfigDto : IDTO
    {
        public int RecordId { get; set; }
        public int MerchantConfigRecordId { get; set; }

        public MerchantConfigDto MerchantConfig { get; set; }

        public string? PaymentEventWebhook { get; set; }

        public string? PaymentEventWebhookSecret { get; set; }

        public string? PaymentEventWebhookId { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
