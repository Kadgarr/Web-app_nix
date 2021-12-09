using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Playlist_of_User_Class
    {
        protected internal int ID_User { get; set; }
        protected internal int ID_Song { get; set; }
        protected internal int ID_Playlist { get; set; }
    }
}
