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
        public int ID_User { get; set; }
        public int ID_Song { get; set; }
        public int ID_Playlist { get; set; }

        public User_Class ID_UserNavigation { get; set; }
        public Song_Class ID_SongNavigation { get; set; }
        public Playlist_Class ID_PlaylistNavigation { get; set; }
    }
}
