using DoeMaisApi.src.Domain.Entities.DonorAggregate;
using DoeMaisApi.src.Domain.Shared;

namespace DoeMaisApi.src.Domain.Entities.BloodCenterAggregate
{
    public class BloodCenter
    {
        public BloodCenter( string responsible, string address, string phoneNumber)
        {
            Responsible = responsible;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public int Id  {get; set;}

        public string Responsible {get; set;}
        
        public string Address {get; set;}
        public string PhoneNumber  {get; set;}

        public void Update(string responsible, string address, string phoneNumber)
        {
            Responsible = responsible;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}