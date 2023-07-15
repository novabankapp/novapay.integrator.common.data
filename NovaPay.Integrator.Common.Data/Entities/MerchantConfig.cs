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

        public bool HasValidation { get; set; } 

        public string? ApiSecretKey { get; set; }

        public string? ApiPublishableKey { get; set; }

        public string? PaymentEventWebhook { get; set; }

        public string? PaymentEventWebhookSecret { get; set; }

        public string? PaymentEventWebhookId { get; set; }

        public Merchant? Merchant { get; set; }

        public bool HasApi { get; set; }
    }
}
