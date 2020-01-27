using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using BullService.Models;
using BullService.Abstraction;
using BullService.Models.Cow;

namespace BullService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowController : ControllerBase
    {
        private readonly ILogger<CowController> _logger;
        private ICowRepository _repo;

        public CowController(ILogger<CowController> logger, ICowRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet("GetAllMeasurements")]
        [ProducesResponseType(typeof(IEnumerable<CowMeasurementModel>), (int) HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllMeasurements([FromQuery]CowMeasurementFilter filter = null)
        {
            var result = await _repo.GetMeasurements(filter);
            return Ok(result);
        }
    }
}
