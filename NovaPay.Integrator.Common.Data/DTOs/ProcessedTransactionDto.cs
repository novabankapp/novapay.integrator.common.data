using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class ProcessedTransactionDto : IDTO
    {
        public int RecordId { get; set; }

        public string ServiceUniqueIdentifier { get; set; }


        public string TransactionRef { get; set; }


        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public string? CustomerRef { get; set; }
    }
}
