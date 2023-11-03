
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class TransactionReferenceNumberDto : IDTO
    {
        public int RecordId { get; set; }

        public string? TRN { get; set; }

        public bool Reusable { get; set; }

        public string? CustomerReference { get; set; }

        public string? CustomerDetails { get; set; }

        public string? QRCodePath { get; set; }

        public MerchantDto? Merchant { get; set; }

        public FinancialInstitutionDto? FinancialInstitution { get; set; }

        
        public decimal? Amount { get; set; }

        public string UserId { get; set; }

        public bool Used { get; set; }

        public string? ServiceUniqueIdentifier { get; set; }

        public string? FinancialServiceUniqueIdentifier { get; set; }

        public string? Metadata { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
