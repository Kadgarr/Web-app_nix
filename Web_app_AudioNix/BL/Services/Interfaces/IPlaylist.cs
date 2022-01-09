using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IPlaylist
    {
        void ChangeName(Guid id_playlist);
        void ViewPlaylist(Guid id_playlist);
        IEnumerable<PlaylistDTO> SortByFavourite();
        IEnumerable<Playlist_of_UserDTO> SearchByItem(string item);

    }
}
