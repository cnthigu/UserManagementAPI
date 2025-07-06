using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.DTOs
{
    public class UserForCreationDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O Nome não pode ter mais de 100 caracteres.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O formato do Email é inválido.")]
        [MaxLength(100, ErrorMessage = "O Email não pode ter mais de 100 caracteres.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MinLength(6, ErrorMessage = "A Senha deve ter no mínimo 6 caracteres.")]
        public string Password { get; set; } = null!;
    }
}
