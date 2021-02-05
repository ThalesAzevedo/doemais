namespace DoeMaisApi.src.Domain.Shared
{
    public class Person
    {
        public Person(string firstName, string lastName, string birthDate, int registrationId)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
        }

        public int Id {get;  set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int RegistrationId { get; set; }
    }
}