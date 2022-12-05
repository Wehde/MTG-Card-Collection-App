using System.ComponentModel.DataAnnotations;

namespace MTG_Card_Collection_App.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
