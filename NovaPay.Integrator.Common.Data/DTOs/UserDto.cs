
using Common.Libraries.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPay.Integrator.Common.Data.DTOs
{
    public class UserDto : IDTO
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public bool IsVerified { get; set; }

        public string ProfilePicPath { get; set; }

        public bool EmailConfirmed { get; set; }
        public string FullName { get; set; }

        public bool IsLocked { get; set; }

        public bool IsDeactivated { get; set; }

        public string PrivateKey { get; set; }

        public string PublicKey { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }     

        public List<RefreshTokenDto> RefreshTokens { get; set; }
    }
}
