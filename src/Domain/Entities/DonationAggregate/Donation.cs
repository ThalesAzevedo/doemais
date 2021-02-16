namespace DoeMaisApi.src.Domain.Entities.DonationAggregate
{
    public class Donation
    {
        public Donation(string donor, string bloodcenter, string status, string schedule, string createdAt)
        {
            Donor = donor;
            Bloodcenter = bloodcenter;
            Status = status;
            Schedule = schedule;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }
        public string Donor { get; set; }	
        public string Bloodcenter { get; set; }
        public string Status { get; set; }  
        public string Schedule { get; set; }
        public string CreatedAt {get; set; }
        public void Update(string bloodcenter, string status, string schedule)    
        {
            Bloodcenter = bloodcenter;
            Status = status;
            Schedule = schedule;
        }
    }

}