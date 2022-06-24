using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class Genres_of_MusicView
    {
        public Guid GenreId { get; set; }
        public Guid SongId { get; set; }

        public GenreView GenreNavigation { get; set; }
        public SongView SongNavigation { get; set; }
    }
}
