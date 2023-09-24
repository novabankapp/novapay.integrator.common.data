using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Libraries.Services.Entities;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class MerchantValidationResponseMapping : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public int MerchantRecordId { get; set; }

        public string MerchantResponseField { get; set; }

        public string LocalResponseField { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
