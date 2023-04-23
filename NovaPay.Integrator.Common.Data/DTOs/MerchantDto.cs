
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantDto : IDTO
    {
        public int RecordId { get; set; }

        public string? ShortCode { get; set; }
        public string? UniqueIdentifier { get; set; }

        public string? Name { get; set; }

        public bool IsActive { get; set; }

        public string? ServiceName { get; set; }

        public ICollection<MerchantProcessDto>? MerchantProcesses { get; set; }

        public MerchantConfigDto? MerchantConfig { get; set; }

        public ICollection<RequestLogDto>? RequestLogs { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
