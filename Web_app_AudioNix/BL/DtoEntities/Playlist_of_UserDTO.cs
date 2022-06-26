using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BL.DtoEntities
{
    public class Playlist_of_UserDTO
    {
        public Guid? UserId { get; set; }
        public Guid? SongId { get; set; }
        public Guid? PlaylistId { get; set; }

        public UserDTO UserNavigation { get; set; }
        public SongDTO SongNavigation { get; set; }
        public PlaylistDTO PlaylistNavigation { get; set; }
    }
}
