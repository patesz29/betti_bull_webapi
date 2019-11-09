using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using BullService.Models;

namespace BullService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BullController : ControllerBase
    {
        private readonly ILogger<BullController> _logger;

        public BullController(ILogger<BullController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BaseModel>), (int) HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(new List<BaseModel>() { new BaseModel() { Priority = 3 } });
        }
    }
}
