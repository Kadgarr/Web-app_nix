using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Web_app_AudioNix.DL
{
    public class Singer
    {
        [Required]
        public Guid SingerId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
        public string Name_of_singer { get; set; }
        public Image Image { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Введите допустимое количество символов в диапазоне от 20 до 500")]
        public string Description { get; set; }

        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }
    }
}
