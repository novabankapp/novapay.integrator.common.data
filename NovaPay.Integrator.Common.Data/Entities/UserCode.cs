using Common.Libraries.Services.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class UserCode : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public string UserId { get; set; }
        public string Code { get; set; }

        public string Token { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
