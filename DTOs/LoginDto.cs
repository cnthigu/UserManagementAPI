using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.DTOs
{
    public class LoginDto
    {

        [Required(ErrorMessage = "O email é obrigatória")]
        [EmailAddress(ErrorMessage = "Formato do email inválido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; }    
    }
}
