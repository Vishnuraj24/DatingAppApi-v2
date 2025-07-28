using System.ComponentModel.DataAnnotations;

namespace MyDatingAppAPI.Dtos
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
