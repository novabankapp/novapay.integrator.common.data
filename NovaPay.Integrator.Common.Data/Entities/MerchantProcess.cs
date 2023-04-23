using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class MerchantProcess : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string Name { get; set; }    

        public int MerchantRecordId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public Merchant? Merchant { get; set; }

        public bool IsAsync { get; set; }
    }
}
