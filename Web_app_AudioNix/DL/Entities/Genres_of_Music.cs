using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Genres_of_Music
    {
        public Guid GenreId { get; set; }
        public Guid SongId { get; set; }

        public Genre GenreNavigation { get; set; }
        public Song SongNavigation { get; set; }
    }
}
