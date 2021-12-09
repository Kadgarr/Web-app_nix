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
        public int ID_Singer { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов (минимум 6)")]
        public string name_of_singer { get; set; }
        public string image { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Введите допустимое количество символов (минимум 20)")]
        public string description { get; set; }

        public List<Song_Class> songs { get; set; }
        public List<Album_Class> albums { get; set; }
    }
}
