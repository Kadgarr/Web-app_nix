using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Genres_of_Music_Class
    {
        public int ID_Genre { get; set; }
        public int ID_Song { get; set; }

        public Song_Class ID_GenreNavigation{get;set;}
        public Song_Class ID_SongNavigation { get; set; }
    }
}
