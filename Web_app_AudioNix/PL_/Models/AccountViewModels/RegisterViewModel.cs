using System.ComponentModel.DataAnnotations;

namespace PL.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Укажите электронный адресс")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        public string Picture { get; set; }
    
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
