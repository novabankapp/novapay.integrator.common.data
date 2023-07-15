using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class NotificationDto : IDTO
    {
        public int RecordId { get; set; }

        public string UserId { get; set; }

        public UserDto User { get; set; }

        public string Message { get; set; }

        public bool Seen { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
