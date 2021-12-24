using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Entities
{
    public class Genre
    {
        [Required]
        public Guid GenreId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
        public string Name_of_Genre { get; set; }
    }
}
