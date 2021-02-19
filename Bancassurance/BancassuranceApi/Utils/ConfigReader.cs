using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Utils
{
    public class ConfigReader : IConfigReader
    {
        private readonly IConfiguration _configuration;

        public ConfigReader(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Read(string key)
        {
            string value = Convert.ToString(_configuration[key]);

            return value;
        }

        public List<string> Read(string upperKey, string lowerKey)
        {
            List<string> values = _configuration.GetSection($"{upperKey}:{lowerKey}").Get<List<string>>();

            return values;
        }
    }
}
