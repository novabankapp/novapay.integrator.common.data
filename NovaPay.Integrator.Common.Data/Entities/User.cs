using Common.Libraries.Services.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Data.Entities
{
    public class User : IdentityUser, IEntity
    {
        public string FullName { get; set; }

        public string PrivateKey { get; set; }

        public bool IsLocked { get; set; }

        public bool IsVerified { get; set; }

        public bool IsDeactivated { get; set; }

        public string PublicKey { get; set; }
        public string ProfilePicPath { get; set; }
        
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
