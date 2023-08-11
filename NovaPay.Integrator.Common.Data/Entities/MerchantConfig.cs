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
    public class MerchantConfig : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int MerchantRecordId { get; set; }

        public MerchantValidationConfig? ValidationConfig { get; set; }

        public MerchantApiKeyConfig? ApiKeyConfig { get; set; }

        public MerchantWebhookConfig? WebhookConfig { get; set; }

        public Merchant? Merchant { get; set; }

        public MerchantApiConfig ApiConfig { get; set; }
    }
}
