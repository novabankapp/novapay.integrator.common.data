
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class RequestLogDto : IDTO
    {
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
