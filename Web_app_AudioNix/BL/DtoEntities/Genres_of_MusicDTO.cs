using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DtoEntities
{
    public class Genres_of_MusicDTO
    {
        public Guid GenreId { get; set; }
        public Guid SongId { get; set; }

        public SongDTO GenreNavigation { get; set; }
        public SongDTO SongNavigation { get; set; }
    }
}
