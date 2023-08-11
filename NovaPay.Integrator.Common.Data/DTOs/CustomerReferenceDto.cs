using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class CustomerReferenceDto : IDTO
    {
        public int RecordId { get; set; }

        public string ServiceUniqueIdentifier { get; set; }

        public string CustomerName { get; set; }

        public string CustomerRef { get; set; }

        public string Details { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
