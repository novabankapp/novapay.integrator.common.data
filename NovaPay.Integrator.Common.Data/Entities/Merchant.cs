
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
    [Index(nameof(UniqueIdentifier), IsUnique = true)]
    public class Merchant : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string UniqueIdentifier { get; set; }

        public string? Name { get; set; }

        public ICollection<MerchantProcess>? MerchantProcesses { get; set; }
        public bool IsActive { get; set; } 
        
        public string? ShortCode { get; set; }

        public int MerchantCategoryRecordId { get; set; }

        public ICollection<MerchantValidationResponseMapping> MerchantValidationResponseMappings { get; set; }

        public ICollection<MerchantPaymentResponseMapping> MerchantPaymentResponseMappings { get; set; }

        public ICollection<FinancialInstitution> AllowedBanks { get; set;}

        public ICollection<TransactionReferenceNumber>? TRNs { get; set; }

        public ICollection<ProductReferenceNumber>? PRNs { get; set; }

        public MerchantCategory? MerchantCategory { get; set; } 

        public string? ServiceName { get; set; }

        public ICollection<RequestLog>? RequestLogs { get; set; }

        public MerchantConfig? MerchantConfig { get; set; }
        

        public DateTime? CreatedAt { get; set; }
    }
}
