using System.Collections.Generic;

namespace DoeMaisApi.src.Domain.Entities.BloodCenterAggregate.Repositories
{
    public interface IBloodCenterRepository
    {
        int Create(BloodCenter bloodCenter);
        void Update(BloodCenter bloodCenter);
        void Remove(BloodCenter bloodCenter);
        BloodCenter GetById(int bloodCenterId);
        IReadOnlyCollection<BloodCenter> GetAll();
    }
}