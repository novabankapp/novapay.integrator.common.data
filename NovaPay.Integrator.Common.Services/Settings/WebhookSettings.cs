using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Settings
{
    public class WebhookSettings : IWebhookSettings
    {
        private readonly IConfiguration _configuration;

        public WebhookSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string WebhookCreationTopic
        {
            get => _configuration["Settings:WebhookCreationTopic"];
        }
        public string WebhookServiceUrl
        {
            get => _configuration["Settings:WebhookServiceUrl"];
        }
        public string BasicUserName
        {
            get => _configuration["Settings:BasicUserName"];
        }

        public string BasicPassword
        {
            get => _configuration["Settings:BasicPassword"];
        }

    }
}
