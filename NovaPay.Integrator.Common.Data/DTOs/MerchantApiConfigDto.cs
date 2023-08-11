using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantApiConfigDto : IDTO
    {
        public int RecordId { get; set; }
        public bool IsCustom { get; set; }

        public int MerchantConfigRecordId { get; set; }

        public MerchantConfigDto MerchantConfig { get; set; }

        public MerchantGeneralApiConfigDto? GeneralApiConfig { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
