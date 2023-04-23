
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class FinancialInstitutionDto : IDTO
    {
        public int RecordId { get; set; }

        public string? Name { get; set; }

        public string? UniqueIdentifier { get; set; }

        public string FinancialServiceName { get; set; }

        public bool IsActive { get; set; }

        public ICollection<RequestLogDto>? RequestLogs { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
