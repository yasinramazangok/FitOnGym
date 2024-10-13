using System.ComponentModel.DataAnnotations;

namespace FitOnWebSite.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Adınızı girmelisiniz!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Emailinizi girmelisiniz!")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi girmelisiniz!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Şifrenizi tekrar girmelisiniz!")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}
