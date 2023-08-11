using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantGeneralApiConfigDto : IDTO
    {
        public int RecordId { get; set; }

        public string BaseUrl { get; set; }

        public int MerchantApiConfigRecordId { get; set; }

        public MerchantApiConfigDto MerchantApiConfig { get; set; }
    }
}
