// using DoeMaisApi.src.Domain.Shared;
using System;
using System.Collections.Generic;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;

namespace DoeMaisApi.src.Domain.Entities.DonorAggregate
{
    public class Donor
{
        public Donor( string firstName, string lastName, DateTime birthDate, string registrationId, DateTime createdAt, string username, string password, string gender, string bloodType /*, string localization, string donations*/)

        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            CreatedAt = createdAt;
            Username = username;
            Password = password;
            Gender = gender;
            BloodType = bloodType;
            // Localization = localization;
            // Donations = donations;

        }
        
        public int DonorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string RegistrationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set;} 
        public string BloodType { get; set;}
        public string Localization { get; set;}
        public ICollection<Donation> Donations { get; set;}

        public void Update( string firstName, string lastName, DateTime birthDate, string registrationId, string username, string password, string gender, string bloodType)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            Username = username;
            Password = password;
            Gender = gender;
            BloodType= bloodType;
        }
    }
}