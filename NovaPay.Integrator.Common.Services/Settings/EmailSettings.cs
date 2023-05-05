using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class EmailSettings : IEmailSettings
    {
        private readonly IConfiguration _configuration;

        public EmailSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string MailServer
        {
            get
            {
                return _configuration["Email:MailServer"];
            }
        }
        public string MailPort
        {
            get
            {
                return this._configuration["Email:MailPort"];
            }
        }
        public string MailSenderName
        {
            get
            {
                return this._configuration["Email:SenderName"];
            }
        }
        public string MailSender
        {
            get
            {
                return _configuration["Email:Sender"];
            }
        }
        public string MailPassword
        {
            get
            {
                return this._configuration["Email:Password"];
            }
        }
    }
}
