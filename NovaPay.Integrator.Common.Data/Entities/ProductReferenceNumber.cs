using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
     public class ProductReferenceNumber : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        public string? PRN { get; set; }
        public Merchant? Merchant { get; set; }

        public string? ProductReference { get; set; }

        //public ICollection<ProductTransaction>? ProductTransactions { get; set; }

        public decimal? Amount { get; set; }

        public int MerchantRecordId { get; set; }

        public string? ProductDetails { get; set; }

        public string? QRCodePath { get; set; }

        public string? Metadata { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
