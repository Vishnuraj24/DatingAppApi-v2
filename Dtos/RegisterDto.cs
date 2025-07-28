using System.ComponentModel.DataAnnotations;

namespace MyDatingAppAPI.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        [MinLength(6)]
        public required string Password
        {
            get; set;
        }
    }
}
