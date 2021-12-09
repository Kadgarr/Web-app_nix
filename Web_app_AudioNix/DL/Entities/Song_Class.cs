using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Song_Class
    {
        [Required]
        public int ID_Song { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        public string name_of_song { get; set; }
        [Required]
        [RegularExpression("{0:dd/MM/yyyy}", ErrorMessage = "Введите дату релиза корректно!")]
        public DateTime date_of_release { get; set; }
        [Required]
        [Range(10,600,ErrorMessage ="Вы вышли за пределы допустимых значений длительности!")]
        public int duration { get; set; }
        public string picture { get; set; }
        public int id_album { get; set; }
        public int id_singer { get; set; }

        public Singer_Class ID_UserNavigation { get; set; }
        public Album_Class ID_AlbumNavigation { get; set; }

        public List<Genres_of_Music_Class> genres_music { get; set; }

    }
}
