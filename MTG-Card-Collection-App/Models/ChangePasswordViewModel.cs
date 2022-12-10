using System.ComponentModel.DataAnnotations;

namespace MTG_Card_Collection_App.Models
{
    public class ChangePasswordViewModel
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter new password.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}