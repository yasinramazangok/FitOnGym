using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FitOnWebSite.Models
{
    public class LoginViewModel 
    {
        [Required(ErrorMessage = "Kullanıcı adını girmelisiniz!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifreyi girmelisiniz!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
