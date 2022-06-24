using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PL.Models
{
    public class Playlist_of_UserView
    {
        public Guid UserId { get; set; }
        public Guid SongId { get; set; }
        public Guid PlaylistId { get; set; }

        public UserView UserNavigation { get; set; }
        public SongView SongNavigation { get; set; }
        public PlaylistView PlaylistNavigation { get; set; }
    }
}
