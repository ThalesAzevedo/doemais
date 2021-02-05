using System.Linq;
using System.Collections.Generic;
using DoeMaisApi.src.Domain.Entities.DonorAggregate;
using DoeMaisApi.src.Domain.Entities.DonorAggregate.Repositories;
using DoeMaisApi.src.Infrastructure.Shared;
using Microsoft.EntityFrameworkCore;

namespace DoeMaisApi.src.Infrastructure.Configurations.Repositories
{
    public class DonorRepository : IDonorRepository
    {
        private readonly DbSet<Donor> _donors;
        private readonly EFContext _context;

        public DonorRepository (EFContext context)
        {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
            _donors = context.Set<Donor>();
        }

        public int Create (Donor donor)
        {
            _donors.Add(donor);
            _context.SaveChanges();
            return donor.Id;
        }

        public Donor GetById(int donorId)
        {
            var donor = _donors.Find(donorId);
            if (donor == null) throw new KeyNotFoundException("Não foi encontrado usuário com este id.");
            return donor;
        }

        public IReadOnlyCollection<Donor> GetAll()
        {
            return _donors.ToList();
        }

        public void Remove(Donor donor)
        {
            _donors.Remove(donor);
            _context.SaveChanges();
        }

        public void Update(Donor donor)
        {
            _donors.Update(donor);
            _context.SaveChanges();
        }
    }
}