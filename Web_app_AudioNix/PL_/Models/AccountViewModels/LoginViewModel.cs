using System.ComponentModel.DataAnnotations;

namespace PL.Models.AccountViewModels
{
    public class LoginViewModel
    {
        //[Required(ErrorMessage = "Укажите электронный адресс")]
        //[EmailAddress]
        //public string Email { get; set; }
        public string Login { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
