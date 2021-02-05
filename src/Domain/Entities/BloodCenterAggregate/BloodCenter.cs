using DoeMaisApi.src.Domain.Shared;

namespace DoeMaisApi.src.Domain.Entities.BloodCenterAggregate
{
    public class BloodCenter
    {
        public int id  {get; set;}

        public Person responsible {get; set;}
        
        public Address address {get; set;}
        public string phoneNumber  {get; set;}
    }
}