using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class GoogleSettings : IGoogleSettings
    {
        private readonly IConfiguration _configuration;

        public GoogleSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GoogleClientId
        {
            get
            {
                return _configuration["Authentication:Google:ClientId"];
            }
        }

        public string GoogleClientSecret
        {
            get
            {
                return _configuration["Authentication:Googles:ClientSecret"];
            }
        }
    }
}
