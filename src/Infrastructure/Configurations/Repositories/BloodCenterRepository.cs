using System.Linq;
using System.Collections.Generic;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate;
using DoeMaisApi.src.Infrastructure.Shared;
using Microsoft.EntityFrameworkCore;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate.Repositories;

namespace DoeMaisApi.src.Infrastructure.Configurations.Repositories
{
    public class BloodCenterRepository : IBloodCenterRepository
    {
        private readonly DbSet<BloodCenter> _bloodCenterDbTable;
        private readonly EFContext _context;

        public BloodCenterRepository (EFContext context)
        {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
            _bloodCenterDbTable = context.Set<BloodCenter>();
        }

        public int Create(BloodCenter bloodcenter)
        {
            _bloodCenterDbTable.Add(bloodcenter);
            _context.SaveChanges();
            return bloodcenter.Id;
        }

        public BloodCenter GetById(int bloodcenterId)
        {
            var bloodcenter = _bloodCenterDbTable.Find(bloodcenterId);
            if (bloodcenter == null) throw new KeyNotFoundException("Não foi encontrado usuário com este id.");
            return bloodcenter;
        }

        public IReadOnlyCollection<BloodCenter> GetAll()
        {
            return _bloodCenterDbTable.ToList();
        }

        public void Remove(BloodCenter bloodcenter)
        {
            _bloodCenterDbTable.Remove(bloodcenter);
            _context.SaveChanges();
        }

        public void Update(BloodCenter bloodcenter)
        {
            _bloodCenterDbTable.Update(bloodcenter);
            _context.SaveChanges();
        }
    }
}
