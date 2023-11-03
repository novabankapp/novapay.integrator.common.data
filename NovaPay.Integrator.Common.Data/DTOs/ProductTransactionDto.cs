using Common.Libraries.Services.Dtos;
using NovaPay.Integrator.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class ProductTransactionDto : IDTO
    {
        public int RecordId { get; set; }

        public decimal TransactionAmount { get; set; }


        public string? ReferenceNumber { get; set; }

        public string? FinancialServiceUniqueIdentifier { get; set; }

        public string? TransactionRef { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
