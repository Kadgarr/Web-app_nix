using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Album
    {
       [Required]
       public Guid AlbumId { get; set; }
       [Required]
       [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
       public string Name_of_album { get; set; }
       [Required]
       [RegularExpression(@"{0:dd/MM/yyyy}", ErrorMessage = "Введите дату релиза корректно!")]
       public DateTime Date_of_release { get; set; }
       public Singer SingerNavigation { get; set; }
    }
}
