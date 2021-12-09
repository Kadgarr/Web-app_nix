using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Album_Class
    {
       [Required]
       public int ID_Album { get; set; }
       [Required]
       [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
       public string name_of_album { get; set; }
       [Required]
       [RegularExpression("{0:dd/MM/yyyy}", ErrorMessage = "Введите дату релиза корректно!")]
       public DateTime date_of_release { get; set; }
       public int id_singer { get; set; }

       public Singer_Class id_singerNavigation { get; set; }
    }
}
