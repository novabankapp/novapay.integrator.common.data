using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class TokenSettings : ITokenSettings
    {
        private readonly IConfiguration _configuration;

        public TokenSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string UserIdSlug
        {
            get
            {
                return _configuration["Token:UserIdSlug"];
            }
        }
        public string JwtKey
        {
            get
            {
                return _configuration["Token:JwtKey"];
            }
        }
        public int JwtLifespanDays
        {
            get
            {
                return int.Parse(_configuration["Token:JwtLifespanDays"]);
            }
        }
        public string JwtIssuer
        {
            get
            {
                return _configuration["Token:JwtIssuer"];
            }
        }
    }
}
