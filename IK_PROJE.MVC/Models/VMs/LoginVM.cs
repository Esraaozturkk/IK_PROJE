using System.ComponentModel.DataAnnotations;

namespace IK_PROJE.MVC.Models.VMs
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Mail adresi girilmesi zorunludur")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre  girilmesi zorunludur")]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;

    }
}
