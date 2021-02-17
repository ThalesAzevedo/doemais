using System;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate;
using DoeMaisApi.src.Domain.Entities.DonorAggregate;

namespace DoeMaisApi.src.Domain.Entities.DonationAggregate
{
    public class Donation
    {
        public Donation(int donorId, int bloodcenterId, string status, DateTime schedule, DateTime createdAt)
        // , Donor donor, BloodCenter bloodCenter)
        {
            DonorId = donorId;
            BloodcenterId = bloodcenterId;
            Status = status;
            Schedule = schedule;
            CreatedAt = createdAt;
            // Donor = donor;
            // BloodCenter = BloodCenter;
        }

        public int DonationId { get; set; }
        public int DonorId { get; set; }	
        public int BloodcenterId { get; set; }
        public string Status { get; set; }  
        public DateTime Schedule { get; set; }
        public DateTime CreatedAt {get; set; }
        public Donor Donor { get; set; }
        public BloodCenter BloodCenter { get; set; }
        public void Update(int bloodcenterId, string status, DateTime schedule, BloodCenter bloodCenter)    
        {
            BloodcenterId = bloodcenterId;
            Status = status;
            Schedule = schedule;
            BloodCenter = bloodCenter;
        }
    }

}