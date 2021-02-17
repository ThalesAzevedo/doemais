using System;
using System.Collections.Generic;
using DoeMaisApi.src.Application.Contracts.Donation;
using DoeMaisApi.src.Domain.Entities.BloodCenterAggregate.Repositories;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;
using DoeMaisApi.src.Domain.Entities.DonationAggregate.Repositories;
using DoeMaisApi.src.Domain.Entities.DonorAggregate.Repositories;

namespace DoeMaisApi.src.Application.Services
{
    public class DonationAppService
    {
        private readonly IDonationRepository _donationRepository;
        private readonly IDonorRepository _donorRepository;
        private readonly IBloodCenterRepository _bloodcenterRepository;

        public DonationAppService(IDonationRepository donationRepository, 
                                  IDonorRepository donorRepository, 
                                  IBloodCenterRepository bloodcenterRepository)
        {
            _donationRepository = donationRepository?? throw new System.ArgumentNullException(nameof(donationRepository));
            _donorRepository = donorRepository?? throw new System.ArgumentNullException(nameof(donorRepository));
            _bloodcenterRepository = bloodcenterRepository?? throw new System.ArgumentNullException(nameof(bloodcenterRepository));
        }

        public int Create (CreateDonationDTO createDonationDTO)
        {   
            DateTime createdAt = DateTime.UtcNow;
            var donor = _donorRepository.GetById(int.Parse(createDonationDTO.DonorId));
            var bloodcenter = _bloodcenterRepository.GetById(int.Parse(createDonationDTO.BloodCenterId));
            var parsedSchedule = DateTime.Parse(createDonationDTO.Schedule);

            Donation donation = new Donation(int.Parse(createDonationDTO.DonorId), 
                                             int.Parse(createDonationDTO.BloodCenterId),
                                             createDonationDTO.Status,
                                             parsedSchedule,
                                             createdAt                                       
                                             );
            return _donationRepository.Create(donation);
        }

        public void Update (int donationId, UpdateDonationDTO updateDonationDTO)
        {
            var parsedDonationId = int.Parse(updateDonationDTO.BloodCenterId);
            var donation = _donationRepository.GetById(donationId);
            var bloodcenter = _bloodcenterRepository.GetById(int.Parse(updateDonationDTO.BloodCenterId));
            var parsedSchedule = DateTime.Parse(updateDonationDTO.Schedule);
            
            donation.Update(parsedDonationId,
                            updateDonationDTO.Status,
                            parsedSchedule,
                            bloodcenter
                            );
            _donationRepository.Update(donation);
        }

        public void RemoveById(int donationId)
        {
            var donation = _donationRepository.GetById(donationId);
            _donationRepository.Remove(donation);
        }

        public Donation GetById(int donationId){
            return _donationRepository.GetById(donationId);
        }

        public IReadOnlyCollection<Donation> GetAll()
        {
            return _donationRepository.GetAll();
        }

    }
}