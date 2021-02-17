using System;
using System.Collections.Generic;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;

namespace DoeMaisApi.src.Domain.Entities.BloodCenterAggregate
{
    public class BloodCenter
    {
        public BloodCenter( string name, string responsible, string address, string phoneNumber, DateTime createdAt)
        {
            Name = name;
            Responsible = responsible;
            Address = address;
            PhoneNumber = phoneNumber;
            CreatedAt = createdAt;
        }

        public int BloodCenterId  {get; set;}
        public string Name { get; set; }
        public string Responsible {get; set;}
        public string Address {get; set;}
        public string PhoneNumber  {get; set;}
        public DateTime CreatedAt { get; set; }
        public ICollection<Donation> Donations { get; set;}

        public void Update(string name, string responsible, string address, string phoneNumber)
        {
            Name = name;
            Responsible = responsible;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}