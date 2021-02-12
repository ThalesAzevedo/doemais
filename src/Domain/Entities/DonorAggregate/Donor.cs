// using DoeMaisApi.src.Domain.Shared;
using DoeMaisApi.src.Domain.Entities.PersonAggregate;

namespace DoeMaisApi.src.Domain.Entities.DonorAggregate
{
    public class Donor
{
        public Donor( string firstName, string lastName, string birthDate, string registrationId, string username, string password, string gender, string bloodType /*, string localization, string donations*/)

        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            Username = username;
            Password = password;
            Gender = gender;
            BloodType = bloodType;
            // Localization = localization;
            // Donations = donations;

        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string RegistrationId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set;} 
        public string BloodType { get; set;}
        // public string Localization  { get; set;1}
        // public string Donations { get; set;}

        public void Update( string firstName, string lastName, string birthDate, string registrationId, string username, string password, string gender, string bloodType)
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