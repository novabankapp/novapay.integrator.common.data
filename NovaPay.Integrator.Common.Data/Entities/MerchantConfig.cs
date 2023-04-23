using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class MerchantConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int MerchantRecordId { get; set; }

        public bool HasValidation { get; set; } 

        public Merchant? Merchant { get; set; }

        public bool HasApi { get; set; }
    }
}
