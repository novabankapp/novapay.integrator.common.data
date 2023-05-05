using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class IdentityServerSettings : IIdentityServerSettings
    {
        private readonly IConfiguration _configuration;

        public IdentityServerSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Url
        {
            get
            {
                return _configuration["Settings:IdentityServerEndPoint"];
            }
        }
    }
}
