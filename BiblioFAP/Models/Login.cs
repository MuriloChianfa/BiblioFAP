using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class Login
    {
        [Required(ErrorMessage = "The E-mail is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [MaxLength(255, ErrorMessage = "The password must be 8-255 characters"), MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The password confirmation is required")]
        [MaxLength(255, ErrorMessage = "The password confirmation must be 8-255 characters"), MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
