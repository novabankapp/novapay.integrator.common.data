using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class MerchantProcessDto : IDTO
    {
        public int RecordId { get; set; }

        public int MerchantRecordId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Name { get; set; }

        public MerchantDto? Merchant { get; set; }

        public bool IsAsync { get; set; }
    }
}
