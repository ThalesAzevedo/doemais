using System;
using System.Collections.Generic;
using DoeMaisApi.src.Application.Contracts.Donor;
using DoeMaisApi.src.Domain.Entities.DonorAggregate;
using DoeMaisApi.src.Domain.Entities.DonorAggregate.Repositories;

namespace DoeMaisApi.src.Application.Services
{
    public class DonorAppService
    {
        private readonly IDonorRepository _donorRepository;

        public DonorAppService(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository?? throw new System.ArgumentNullException(nameof(donorRepository));
        }

        public int Create(CreateDonorDTO createDonor )
        {
            DateTime parsedBirthDate = DateTime.Parse(createDonor.BirthDate);
            DateTime createdAt = DateTime.UtcNow;
            Donor donor = new Donor(createDonor.FirstName,
                                    createDonor.LastName, 
                                    parsedBirthDate, 
                                    createDonor.RegistrationId, 
                                    createdAt,
                                    createDonor.Username, 
                                    createDonor.Password, 
                                    createDonor.Gender, 
                                    createDonor.BloodType
                                    );
            return _donorRepository.Create(donor);  
        }

        public void Updade(int donorId, UpdateDonorDTO updateDonor)
        {
            DateTime parsedBirthDate = DateTime.Parse(updateDonor.BirthDate);
            var donor = _donorRepository.GetById(donorId);
            donor.Update(updateDonor.FirstName,
                         updateDonor.LastName, 
                         parsedBirthDate, 
                         updateDonor.RegistrationId,
                         updateDonor.Username, 
                         updateDonor.Password, 
                         updateDonor.Gender, 
                         updateDonor.BloodType
            );
            _donorRepository.Update(donor);

        }

        public void RemoveById(int donorId)
        {
            var donor = _donorRepository.GetById(donorId);
            _donorRepository.Remove(donor);

        }

        public Donor GetById( int donorId)
        {
            return _donorRepository.GetById(donorId);
        }

        public IReadOnlyCollection<Donor> GetAll()
        {
            return _donorRepository.GetAll();
        }
    }
}