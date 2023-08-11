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
    [Index(nameof(ServiceUniqueIdentifier), IsUnique = true)]
    public class ProcessedTransaction : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string ServiceUniqueIdentifier { get; set; }

        
        public string TransactionRef { get; set; }

       
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public string? CustomerRef { get; set; }
    }
}
