using System.ComponentModel.DataAnnotations;

namespace UdemyProject.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınız Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Adresi Giriniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrelerin Aynı Olduğundan Emin Olun.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Giriniz.")]
        public string Mail { get; set; }
    }
}
