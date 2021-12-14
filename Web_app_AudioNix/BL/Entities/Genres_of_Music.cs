using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Genres_of_Music
    {
        public Guid GenreId { get; set; }
        public Guid SongId { get; set; }

        public Song GenreNavigation { get; set; }
        public Song SongNavigation { get; set; }
    }
}
