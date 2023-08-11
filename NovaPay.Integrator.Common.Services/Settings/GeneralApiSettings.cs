using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class GeneralApiSettings : IGeneralApiSettings
    {
        private readonly IConfiguration _configuration;

        public GeneralApiSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ServiceName
        {
            get
            {
                return _configuration["GeneralApiSettings:ServiceName"];
            }
        }
        public string ValidateUrl
        {
            get
            {
                return _configuration["GeneralApiSettings:ValidateUrl"];
            }
        }
        public string TransactionUrl
        {
            get
            {
                return _configuration["GeneralApiSettings:TransactionUrl"];
            }
        }
    }
}
