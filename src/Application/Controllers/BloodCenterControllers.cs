using System;
using System.Collections.Generic;
using System.Net;
using DoeMaisApi.src.Application.Contracts.BloodCenter;
using DoeMaisApi.src.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoeMaisApi.src.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BloodCenterControllers : ControllerBase
    {
        private readonly BloodCenterAppService _bloodcenterAppService;

        public  BloodCenterControllers(  BloodCenterAppService bloodcenterAppService)
        {
            _bloodcenterAppService = bloodcenterAppService?? throw new ArgumentNullException(nameof(bloodcenterAppService));
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var bloodcenterList = _bloodcenterAppService.GetAll();
            return Ok(bloodcenterList);
        }

        [HttpGet("{bloodcenterId}")]
        public IActionResult GetById(int bloodcenterId)
        {
            try {
                var bloodcenter = _bloodcenterAppService.GetById(bloodcenterId);
                return Ok(bloodcenter);
            }
            catch(KeyNotFoundException){
                return NotFound();
            }            
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateBloodCenterDTO createBloodCenter)
        {
            var bloodcenterId = _bloodcenterAppService.Create(createBloodCenter);
            return new ObjectResult(bloodcenterId)
            {
                StatusCode = (int) HttpStatusCode.Created
            };
        }

        [HttpPut("{bloodcenterId}")]
        public IActionResult Update (int bloodcenterId, [FromBody] UpdateBloodCenterDTO updateBloodCenter)
        {
            try {
                _bloodcenterAppService.Updade(bloodcenterId, updateBloodCenter);
                return Ok();
            }
            catch (KeyNotFoundException) {
                return NotFound();
            }
        }
        
        [HttpDelete("{bloodcenterId}")]
        public IActionResult DeleteById(int bloodcenterId)
        {
            try {
                _bloodcenterAppService.RemoveById(bloodcenterId);
                return NoContent();

            }
            catch (KeyNotFoundException) {
                return NotFound();
            }
        }

    }
}
