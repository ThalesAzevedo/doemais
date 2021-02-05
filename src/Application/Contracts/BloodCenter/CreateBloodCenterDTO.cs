using System.ComponentModel.DataAnnotations;
using DoeMaisApi.src.Domain.Shared;

namespace DoeMaisApi.src.Application.Contracts.BloodCenter
{
    public class CreateBloodCenterDTO
    {
        [Required(ErrorMessage = "Responsável pelo banco de sangue é obrigatório.")]
        public Person responsible {get; set;}
        [Required(ErrorMessage = "Endereço é obrigatório.")]
        public Address address {get; set;}
        [Required(ErrorMessage = "Número de contato é obrigatório.")]
        public string phoneNumber  {get; set;}
        
    }
}