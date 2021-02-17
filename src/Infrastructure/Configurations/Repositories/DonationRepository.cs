using System.Collections.Generic;
using System.Linq;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;
using DoeMaisApi.src.Domain.Entities.DonationAggregate.Repositories;
using DoeMaisApi.src.Infrastructure.Shared;
using Microsoft.EntityFrameworkCore;

namespace DoeMaisApi.src.Infrastructure.Configurations.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        private readonly DbSet<Donation> _donationDb;

        private readonly EFContext _context;

        public DonationRepository (EFContext context)
        {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
            _donationDb = context.Set<Donation>();
        }

        public int Create(Donation donation)
        {
            _donationDb.Add(donation);
            _context.SaveChanges();
            return donation.DonationId;
        }

        public void Update(Donation donation)
        {
            _donationDb.Update(donation);
            _context.SaveChanges();
        }

        public void Remove(Donation donation)
        {
            _donationDb.Remove(donation);
            _context.SaveChanges();
        }

        public Donation GetById(int donationId)
        {
            var donation = _donationDb.Find(donationId);
            if (donation==null) throw new KeyNotFoundException("Não foi encontrada nenhum doação com este id.");
            return donation;
        }
    
        public IReadOnlyCollection<Donation> GetAll()
        {
            return _donationDb.ToList();
        }
    }
}