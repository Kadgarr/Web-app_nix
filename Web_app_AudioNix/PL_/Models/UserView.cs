using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PL.Models
{
    public class UserView
    {
        [Required(ErrorMessage = "Укажите id",AllowEmptyStrings =false)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Укажите электронный адресс")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Вы вышли за пределы допустимого кол-ва значений")]
        [StringLength(40, MinimumLength = 3)]
        public string Picture { get; set; }

        public string Login { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
        [RegularExpression(@"{0:dd/MM/yyyy}", ErrorMessage = "Введите дату регистрации корректно!")]
        public DateTime Date_of_registration{ get; set; }
        public virtual List<Playlist_of_UserView> Playlists_Of_User { get; set; }

    }
}
