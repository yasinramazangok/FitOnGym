using System.ComponentModel.DataAnnotations;

namespace FitOnWebSite.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }
    }
}
