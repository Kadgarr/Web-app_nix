using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;

namespace BL.Services.Interfaces
{
    interface IPlaylist
    {
        void ChangeName(Guid id_playlist);
        void ViewPlaylist(Guid id_playlist);
        IEnumerable<Playlist> GetAll();
        IEnumerable<Playlist> SortByInc();
        IEnumerable<Playlist> SortByDesc();
        IEnumerable<Playlist> SortByFavourite();

    }
}
