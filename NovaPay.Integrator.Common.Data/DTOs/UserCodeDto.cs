
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class UserCodeDto : IDTO
    {
        public int RecordId { get; set; }
        public string UserId { get; set; }
        public string Code { get; set; }

        public string Token { get; set; }

        public DateTime ExpiryDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }
    }
}
