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
        private readonly ILogger<ApiController> _logger;
        private static int _count;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok("0.0.2");
        }

        [HttpGet("data")]
        public IActionResult GetData()
        {
            return Json(new { Count = ++_count, Host = System.Net.Dns.GetHostName() });
        }
    }
}
