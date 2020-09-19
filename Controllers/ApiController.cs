using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private const string VERSION = "0.0.6";
        private readonly ILogger<ApiController> _logger;
        private static int _count;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok(VERSION);
        }

        [HttpGet("data")]
        public IActionResult GetData()
        {
            return Json(new 
            { 
                ApiVersion = VERSION,
                Count = ++_count, 
                Host = System.Net.Dns.GetHostName() 
            });
        }
    }
}
