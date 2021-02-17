using DoeMaisApi.src.Application.Contracts.BloodCenter;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate.Repositories;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate;
using System.Collections.Generic;
using System;

namespace DoeMaisApi.src.Application.Services
{
    public class BloodCenterAppService
    {
        private readonly IBloodCenterRepository _bloodCenterRepository;

        public BloodCenterAppService(IBloodCenterRepository BloodCenterRepository)
        {
            _bloodCenterRepository = BloodCenterRepository?? throw new System.ArgumentNullException(nameof(BloodCenterRepository));
        }

        public int Create(CreateBloodCenterDTO createBloodCenter )
        {
            DateTime createdAt = DateTime.UtcNow;
            BloodCenter BloodCenter = new BloodCenter(createBloodCenter.Name,
                                                      createBloodCenter.Responsible,
                                                      createBloodCenter.Address, 
                                                      createBloodCenter.PhoneNumber,
                                                      createdAt
                                                      );
            return _bloodCenterRepository.Create(BloodCenter);  
        }

        public void Updade(int BloodCenterId, UpdateBloodCenterDTO updateBloodCenter)
        {
            var BloodCenter = _bloodCenterRepository.GetById(BloodCenterId);
            BloodCenter.Update(updateBloodCenter.Name, updateBloodCenter.Responsible, updateBloodCenter.Address, updateBloodCenter.PhoneNumber);
            _bloodCenterRepository.Update(BloodCenter);

        }

        public void RemoveById(int BloodCenterId)
        {
            var BloodCenter = _bloodCenterRepository.GetById(BloodCenterId);
            _bloodCenterRepository.Remove(BloodCenter);

        }

        public BloodCenter GetById( int BloodCenterId)
        {
            return _bloodCenterRepository.GetById(BloodCenterId);
        }

        public IReadOnlyCollection<BloodCenter> GetAll()
        {
            return _bloodCenterRepository.GetAll();
        }
    }
}