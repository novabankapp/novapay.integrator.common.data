using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantPaymentResponseMappingDto : IDTO
    {
        public int RecordId { get; set; }

        public int MerchantRecordId { get; set; }

        public string MerchantResponseField { get; set; }

        public string LocalResponseField { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
