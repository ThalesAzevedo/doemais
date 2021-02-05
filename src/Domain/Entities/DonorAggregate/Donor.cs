using DoeMaisApi.src.Domain.Shared;

namespace DoeMaisApi.src.Domain.Entities.DonorAggregate
{
    public class Donor
{
        public Donor( string firstName, string lastName, string birthDate, string registrationId, string gender, string bloodType)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            Gender = gender;
            BloodType = bloodType;
        }

        public int Id {get;  set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string RegistrationId { get; set; }
        public string Gender {get; set;} 

        public string BloodType {get; set;}

        // public string Localization  {get; set;}

        // public string Donations {get; set;}

        public void Update( string firstName, string lastName, string birthDate, string registrationId, string gender, string bloodType)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            Gender = gender;
            BloodType= bloodType;
        }
    }
}