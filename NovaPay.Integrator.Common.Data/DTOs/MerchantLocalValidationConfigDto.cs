using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantLocalValidationConfigDto : IDTO
    {
        public int RecordId { get; set; }

        public int MerchantValidationConfigRecordId { get; set; }

        public string TableName { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
