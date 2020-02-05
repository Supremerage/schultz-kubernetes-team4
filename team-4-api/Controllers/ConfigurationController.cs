using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace team_4_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public ConfigurationController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public IActionResult GetConfiguration()
        {
            var config = new CustomConfig()
            {
                Environment = _configuration[$"{CustomConfig.SectionKey}:Environment"]
            };

            var result = new
            {
                config.Environment,
                _env.EnvironmentName
            };

            return Ok(result);
        }
    }
}