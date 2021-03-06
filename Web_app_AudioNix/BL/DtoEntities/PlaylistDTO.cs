using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BL.DtoEntities
{
    public class PlaylistDTO
    {
        [Required]
        public Guid PlaylistId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Введите допустимое количество символов в диапазоне от 6 до 50")]
        public string Name_of_playlist { get; set; }
        [Required]
        public bool LikeCheck { get; set; }
    }
}
