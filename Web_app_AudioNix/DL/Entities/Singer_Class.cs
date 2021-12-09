using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Singer_Class
    {
        [Required]
        protected internal int ID_Singer { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        protected internal string name_of_singer { get; set; }
        protected internal string image { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Введите допустимое количество символов (минимум 20)")]
        protected internal string description { get; set; }

        protected internal List<Song_Class> songs { get; set; }
        protected internal List<Album_Class> albums { get; set; }
    }
}
