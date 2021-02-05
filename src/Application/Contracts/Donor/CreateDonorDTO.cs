using System.ComponentModel.DataAnnotations;

namespace DoeMaisApi.src.Application.Contracts.Donor
{
    public class CreateDonorDTO


    {
        [Required(ErrorMessage = "Nome de usuário é obrigatorio.")]
        [MinLength(3)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome de usuário é obrigatório.")]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        [StringLength(8)]
        public string BirthDate { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório.")]
        [StringLength(11)]
        public string RegistrationId { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [MaxLength(1)]

        public string Gender {get; set;} 
        [Required(ErrorMessage = "O tipo sanguineo é obrigatório.")]
        [MaxLength(3)]
        public string BloodType {get; set;}
    }
}