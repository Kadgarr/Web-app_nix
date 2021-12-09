using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Playlist_Class
    {
        [Required]
        protected internal int ID_Playlist { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        protected internal string name_of_playlist { get; set; }
    }
}
