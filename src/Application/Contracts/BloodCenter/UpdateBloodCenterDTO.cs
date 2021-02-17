using System.ComponentModel.DataAnnotations;
using DoeMaisApi.src.Domain.Shared;

namespace DoeMaisApi.src.Application.Contracts.BloodCenter
{
    public class UpdateBloodCenterDTO
    {
        [Required(ErrorMessage = "Nome da instituição é necessário.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Responsável pelo banco de sangue é obrigatório.")]
        public string Responsible {get; set;}
        [Required(ErrorMessage = "Necessário definir a pessoa responsável.")]
        public string Address {get; set;}
        [Required(ErrorMessage = "Número de contato é obrigatório.")]
        public string PhoneNumber  {get; set;}
    }
}