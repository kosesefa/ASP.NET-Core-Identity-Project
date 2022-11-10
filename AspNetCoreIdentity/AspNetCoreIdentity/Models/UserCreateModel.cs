using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace AspNetCoreIdentity.Models
{
    public class UserCreateModel
    {
        [Required(ErrorMessage ="Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage ="E-mail formatında bir mail adresi giriniz.")]
        [Required(ErrorMessage ="Mail adresi gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Parola alanı gereklidir.")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Parolalar eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Cinsiyet gereklidir.")]
        public string Gender { get; set; }
    }
}
