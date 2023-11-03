using Common.Libraries.Services.Dtos;
using NovaPay.Integrator.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class ProductReferenceNumberDto : IDTO
    {
        public int RecordId { get; set; }

        public string? PRN { get; set; }
        public MerchantDto? Merchant { get; set; }

        public string? ProductReference { get; set; }

        public ICollection<ProductTransactionDto>? ProductTransactions { get; set; }

        public decimal? Amount { get; set; }

        public int MerchantRecordId { get; set; }

        public string? ProductDetails { get; set; }

        public string? QRCodePath { get; set; }

        public string? Metadata { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
