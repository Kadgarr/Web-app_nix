using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Genre_Class
    {
        [Required]
        protected internal int ID_Genre { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        protected internal string name_of_Genre { get; set; }
    }
}
