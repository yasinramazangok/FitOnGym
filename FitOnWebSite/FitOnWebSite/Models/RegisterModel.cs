using System.ComponentModel.DataAnnotations;

namespace FitOnWebSite.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil, kontrol edin!")]
        public string PasswordConfirm { get; set; }
    }
}
