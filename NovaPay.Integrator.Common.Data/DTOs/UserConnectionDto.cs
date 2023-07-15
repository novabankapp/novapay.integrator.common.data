using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class UserConnectionDto : IDTO
    {
        public int RecordId { get; set; }
        public string UserId { get; set; }

        public string ConnectionId { get; set; }

        public UserDto User { get; set; }
    }
}
