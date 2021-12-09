using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Genres_of_Music_Class
    {
        protected internal int ID_Genre { get; set; }
        protected internal int ID_Song { get; set; }

        protected internal Song_Class ID_GenreNavigation{get;set;}
        protected internal Song_Class ID_SongNavigation { get; set; }
    }
}
