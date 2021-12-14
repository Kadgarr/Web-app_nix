using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_app_AudioNix.DL
{
    public class Playlist_of_User
    {
        public Guid UserId { get; set; }
        public Guid SongId { get; set; }
        public Guid PlaylistId { get; set; }

        public User UserNavigation { get; set; }
        public Song SongNavigation { get; set; }
        public Playlist PlaylistNavigation { get; set; }
    }
}
