
using Common.Libraries.Services.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    [Index(nameof(TRN), IsUnique = true)]
    public class TransactionReferenceNumber : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        
        public string? TRN { get; set; }

        public string? CustomerReference { get; set; }

        public Merchant? Merchant { get; set; }

        public FinancialInstitution? FinancialInstitution { get; set; }

        public decimal? Amount { get; set; }

        public bool Used { get; set; }

        public string UserId { get; set; }

        public string? ServiceUniqueIdentifier { get; set;}

        public string? FinancialServiceUniqueIdentifier { get; set; } 

        public int MerchantRecordId { get; set; }

        public string? CustomerDetails { get; set; }

        public string? QRCodePath { get; set; }

        public int? FinancialInstitutionRecordId { get; set; }

        public string? Metadata { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
