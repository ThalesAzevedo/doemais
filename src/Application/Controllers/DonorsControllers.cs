using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DoeMaisApi.src.Application.Contracts.Donor;
using DoeMaisApi.src.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace DoeMaisApi.src.Application.Controllers
{
    [ApiController]
    [Route("api/donors")]
    public class DonorControllers : ControllerBase
    {
        private readonly DonorAppService _donorAppService;

        public DonorControllers( DonorAppService donorAppService)
        {
            _donorAppService = donorAppService?? throw new ArgumentNullException(nameof(donorAppService));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _donorAppService.GetAll();
            return Ok(userList);
        }

        [HttpGet("{donorId}")]
        public IActionResult GetById(int donorId)
        {
            try {
                var donor = _donorAppService.GetById(donorId);
                return Ok(donor);
            }
            catch(KeyNotFoundException){
                return NotFound();
            }            
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateDonorDTO createDonor)
        {
            var donorId = _donorAppService.Create(createDonor);
            return new ObjectResult(donorId)
            {
                StatusCode = (int) HttpStatusCode.Created
            };
        }

        [HttpPut("{donorId}")]
        public IActionResult Update (int donorId, [FromBody] UpdateDonorDTO updateDonor)
        {
            try {
                _donorAppService.Updade(donorId, updateDonor);
                return Ok();
            }
            catch (KeyNotFoundException) {
                return NotFound();
            }
        }
        
        [HttpDelete("{donorId}")]
        public IActionResult DeleteById(int donorId)
        {
            try {
                _donorAppService.RemoveById(donorId);
                return NoContent();

            }
            catch (KeyNotFoundException) {
                return NotFound();
            }
        }

    }
}
