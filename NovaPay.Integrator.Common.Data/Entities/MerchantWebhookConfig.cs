using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class MerchantWebhookConfig : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public int MerchantConfigRecordId { get; set; }

        public MerchantConfig MerchantConfig { get; set; }

        public string? PaymentEventWebhook { get; set; }

        public string? PaymentEventWebhookSecret { get; set; }

        public string? PaymentEventWebhookId { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
