using System.ComponentModel.DataAnnotations;

namespace DoeMaisApi.src.Application.Contracts.Donation
{
    public class CreateDonationDTO
    {   
        [Required(ErrorMessage= "Doador é necessário.")]
        public string DonorId { get; set; }
        [Required(ErrorMessage= "Banco de Sangue é necessário.")]
        public string BloodCenterId { get; set; }
        [Required(ErrorMessage= "Status da doação é necessário.")]
        public string Status { get; set; }
        [Required(ErrorMessage= "Data de doação é necessária.")]        
        public string Schedule { get; set; }
    }
}