using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
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
            try
            {
                var result = await _repo.GetMeasurements(filter);
                return Ok(result);
            }

            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("CreateOrUpdateMeasurement")]
        [ProducesResponseType(typeof(CowMeasurementModel), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(CowMeasurementModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateMeasurement([FromBody]CowMeasurementModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Model is not valid");
                }
                var result = await _repo.CreateOrUpdateMeasurement(model);
                if (result?.IsSuccess ?? false)
                    return Created(HttpContext.Request.Scheme, result?.Payload);
                return BadRequest();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("CreateOrUpdateCow")]
        [ProducesResponseType(typeof(CowModel), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(CowModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateCow([FromBody]CowModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Model is not valid");
                }
                var result = await _repo.CreateOrUpdateCow(model);
                if (result?.IsSuccess ?? false)
                    return Created(HttpContext.Request.Scheme, result?.Payload);
                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
