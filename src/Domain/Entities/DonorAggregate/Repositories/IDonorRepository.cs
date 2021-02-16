using System.Collections.Generic;

namespace DoeMaisApi.src.Domain.Entities.DonorAggregate.Repositories
{
    public interface IDonorRepository
    {
        int Create(Donor donor);
        void Update(Donor donor);
        
        void Remove(Donor donor);
        Donor GetById(int donorId);
        IReadOnlyCollection<Donor> GetAll();
    }
}