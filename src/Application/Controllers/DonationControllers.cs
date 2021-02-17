using System;
using System.Collections.Generic;
using System.Net;
using DoeMaisApi.src.Application.Contracts.Donation;
using DoeMaisApi.src.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoeMaisApi.src.Application.Controllers
{
    [ApiController]
    [Route("api/donations")]
    public class DonationControllers : ControllerBase
    {
        private readonly DonationAppService _donationAppService;

        public DonationControllers( DonationAppService donorAppService)
        {
            _donationAppService = donorAppService?? throw new ArgumentNullException(nameof(donorAppService));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var donationList = _donationAppService.GetAll();
            return Ok(donationList);
        }

        [HttpGet("{donationId}")]
        public IActionResult GetById(int donationId)
        {
            try {
                var donation = _donationAppService.GetById(donationId);
                return Ok(donation);
            } catch(KeyNotFoundException) {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateDonationDTO createdDonation)
        {
            var donorId = _donationAppService.Create(createdDonation);
            return new ObjectResult(donorId)
            {
                StatusCode = (int) HttpStatusCode.Created
            };
        }

        [HttpPut("{donationId}")]
        public IActionResult Update (int donationId, [FromBody] UpdateDonationDTO updateDonation)
        {
            try {
                _donationAppService.Update(donationId, updateDonation);
                return Ok();
            } catch(KeyNotFoundException) {
                return NotFound();
            }
        }
        
        [HttpDelete("{donationId}")]
        public IActionResult DeleteById(int donationId)
        {
            try{
                _donationAppService.RemoveById(donationId);
                return NoContent();
            } catch (KeyNotFoundException) {
                return NotFound();
            }
        }


        

    }
}