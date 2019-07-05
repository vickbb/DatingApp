using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 a 12 caracteres")]
        public string Password { get; set; }
    }
}