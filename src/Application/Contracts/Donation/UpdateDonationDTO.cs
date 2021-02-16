using System.ComponentModel.DataAnnotations;

namespace DoeMaisApi.src.Application.Contracts.Donation
{
    public class UpdateDonationDTO
    {
        [Required(ErrorMessage= "Banco de Sangue é necessário.")]
        public string  BloodCenter { get; set; }
        [Required(ErrorMessage= "Status da doação é necessário.")]
        public string Status { get; set; }
        [Required(ErrorMessage= "Data de doação é necessária.")]        
        public string Schedule { get; set; }


    }
}