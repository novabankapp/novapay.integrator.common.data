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
    public class MerchantApiConfig : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public bool IsCustom { get; set; }

        public int MerchantConfigRecordId { get; set; }

        public MerchantConfig MerchantConfig { get; set; }

        public MerchantGeneralApiConfig? GeneralApiConfig { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
