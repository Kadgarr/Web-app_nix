using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public class GenreView
    {
        [Required]
        public Guid GenreId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
        public string Name_of_Genre { get; set; }
    }
}
