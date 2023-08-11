using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantValidationConfigDto : IDTO
    {
        public int RecordId { get; set; }
        public bool IsLocal { get; set; }

        public int MerchantConfigRecordId { get; set; }

        public MerchantConfigDto MerchantConfig { get; set; }

        public MerchantLocalValidationConfigDto? LocalValidationConfig { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
