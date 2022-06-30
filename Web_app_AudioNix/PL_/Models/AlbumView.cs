using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PL.Models
{
    public class AlbumView
    {
       [Required]
       public Guid AlbumId { get; set; }
       [Required]
       [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
       public string Name_of_album { get; set; }
       [Required]
       [RegularExpression(@"{0:dd/MM/yyyy}", ErrorMessage = "Введите дату релиза корректно!")]
       public DateTime Date_of_release { get; set; }
       public Image Picture { get; set; }

       public SingerView SingerNavigation { get; set; }
       public List<SongView> Songs { get; set; }
    }
}
