using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IPlaylist
    {
        PlaylistDTO ViewPlaylist(Guid id_playlist);
        IEnumerable<PlaylistDTO> SortByFavourite();
        IEnumerable<Playlist_of_UserDTO> SearchByUser(Guid userId);

    }
}
