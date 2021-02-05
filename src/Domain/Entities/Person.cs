namespace DoeMaisApi.src.Domain.Entities
{
    public class Person
    {
        public Person(string firstName, string lastName, string birthDate, string registrationId, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            RegistrationId = registrationId;
            Username = username;
            Password = password;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string RegistrationId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}