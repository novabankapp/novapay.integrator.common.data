
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
    public class FinancialInstitution : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string? Name { get; set; }

        public string UniqueIdentifier { get; set; }

        public bool IsActive { get; set; }

        public string FinancialServiceName { get; set; }
        public int FinancialInstitutionCategoryRecordId { get; set; } 

        public FinancialInstitutionConfig Config { get; set; }

        public FinancialInstitutionCategory? FinancialInstitutionCategory { get; set; }

        public ICollection<TransactionReferenceNumber>? TRNs { get; set; }

        public ICollection<RequestLog>? RequestLogs { get; set; }
        public DateTime? CreatedAt { get; set; }

        
    }
}
