using System.Collections.Generic;

namespace DoeMaisApi.src.Domain.Entities.DonationAggregate.Repositories
{
    public interface IDonationRepository
    {
        int Create(Donation donation);
        void Update(Donation donation);
        void Remove(Donation donation);
        Donation GetById(int donationId);
        IReadOnlyCollection<Donation> GetAll();
    }
}