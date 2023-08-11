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
    public class CustomerReference : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string ServiceUniqueIdentifier { get; set; }

        public string CustomerName { get; set; }

        public string CustomerRef { get; set; }

        public string Details { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
