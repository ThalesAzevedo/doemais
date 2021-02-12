using System.ComponentModel.DataAnnotations;

namespace DoeMaisApi.src.Application.Contracts.Donor
{
    public class UpdateDonorDTO
    {
        [Required(ErrorMessage = "Nome de usuário é obrigatorio.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Sobrenome de usuário é obrigatório.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        public string BirthDate { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório.")]
        public string RegistrationId { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public string Gender {get; set;} 
        [Required(ErrorMessage = "O tipo sanguineo é obrigatório.")]
        public string BloodType {get; set;}
    }

    //TODO: Implementar outras propriedades.
}