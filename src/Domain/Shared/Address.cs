namespace DoeMaisApi.src.Domain.Shared
{
    public class Address
    {
        public Address(string street, string number, string district, string city, string state, string postalCode, string localization)
        {
            Street = street;
            Number = number;
            District = district;
            City = city;
            State = state;
            PostalCode = postalCode;
            Localization = localization;
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Localization { get; set; }
    }
}