using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetVideoCore.Services
{
    public class ConfigurationMessageService : IMessageService
    {
        private IConfiguration _configuration;
        public string GetMessage()
        {
            return _configuration["Message"];
        }

        public ConfigurationMessageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
