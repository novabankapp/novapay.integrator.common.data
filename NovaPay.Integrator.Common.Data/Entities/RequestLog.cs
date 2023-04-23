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
    public class RequestLog : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string? FinancialServiceId { get; set; }

        public string? MerchantId { get; set; }

        public string? RequestUrl { get; set; }
        public string? RawRequest { get; set; }
        public string? RawResponse { get; set; }
        public int? ResponseStatusCode { get; set; }
        public string? Message { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? ResponseTime { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
