using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class User_Class
    {
        [Required(ErrorMessage = "Укажите id",AllowEmptyStrings =false)]
        public string ID_User { get; set; }
        [Required(ErrorMessage = "Укажите электронный адресс")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Вы вышли за пределы допустимого кол-ва значений")]
        [StringLength(40, MinimumLength = 3)]
        public string login { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        public string password { get; set; }
        public int id_song { get; set; }
    }
}
