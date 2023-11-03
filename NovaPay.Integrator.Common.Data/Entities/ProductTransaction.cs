using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class ProductTransaction : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public decimal TransactionAmount { get; set; }

        public string? ReferenceNumber { get; set; }

        public string? FinancialServiceUniqueIdentifier { get; set; }

        public string? TransactionRef { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
