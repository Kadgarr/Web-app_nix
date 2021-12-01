using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    class Song_Class
    {
        internal int ID_Song { get; set; }
        internal string name_of_song { get; set; }
        internal DateTime date_of_release { get; set; }
        internal string duration { get; set; }
        internal string picture { get; set; }
        internal int id_album { get; set; }
        internal int id_singer { get; set; }

    }
}
