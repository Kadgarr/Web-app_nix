﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_app_AudioNix.DL
{
    public class Song_Class
    {
        protected internal int ID_Song { get; set; }
        protected internal string name_of_song { get; set; }
        protected internal DateTime date_of_release { get; set; }
        protected internal string duration { get; set; }
        protected internal string picture { get; set; }
        protected internal int id_album { get; set; }
        protected internal int id_singer { get; set; }

        protected internal Singer_Class ID_UserNavigation { get; set; }
        protected internal Album_Class ID_AlbumNavigation { get; set; }

        protected internal List<Genres_of_Music_Class> genres_music { get; set; }

    }
}