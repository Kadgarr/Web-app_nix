using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PL.Models
{
    public class SongView
    {
        [Required]
        public Guid SongId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "ВВведите допустимое количество символов в диапазоне от 1 до 100")]
        public string Name_of_song { get; set; }
        [Required]
        [RegularExpression(@"{0:dd/MM/yyyy}", ErrorMessage = "Введите дату релиза корректно!")]
        public DateTime Date_of_release { get; set; }
        [Required]
        [Range(10,600,ErrorMessage ="Вы вышли за пределы диапазона значений длительности от 10 до 600 секунд!")]
        public int Duration { get; set; }

        [Required]
        public string Source { get; set; }
        public string Picture { get; set; }

        public SingerView IdSingerNavigation { get; set; }
        public AlbumView IdAlbumNavigation { get; set; }

        public virtual List<Genres_of_MusicView> Genres_music { get; set; }

    }
}
