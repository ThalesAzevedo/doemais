using System.Collections.Generic;
using DoeMaisApi.src.Application.Contracts.Donation;
using DoeMaisApi.src.Domain.Entities.DonationAggregate;
using DoeMaisApi.src.Domain.Entities.DonationAggregate.Repositories;

namespace DoeMaisApi.src.Application.Services
{
    public class DonationAppService
    {
        private readonly IDonationRepository _donationRepository;

        public DonationAppService(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository?? throw new System.ArgumentNullException(nameof(donationRepository));
        }

        public int Create (CreateDonationDTO createDonationDTO)
        {
            Donation donation = new Donation(createDonationDTO.Donor, 
                                             createDonationDTO.BloodCenter,
                                             createDonationDTO.Status,
                                             createDonationDTO.Schedule,
                                             createDonationDTO.CreatedAt
                                             );
            return _donationRepository.Create(donation);
        }

        public void Update (int donationId, UpdateDonationDTO updateDonationDTO)
        {
            var donation = _donationRepository.GetById(donationId);
            donation.Update(updateDonationDTO.BloodCenter,
                            updateDonationDTO.Status,
                            updateDonationDTO.Schedule);
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