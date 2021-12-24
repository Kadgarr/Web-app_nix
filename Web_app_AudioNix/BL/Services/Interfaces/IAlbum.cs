using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;

namespace BL.Services.Interfaces
{
    interface IAlbum
    {
        IEnumerable<Album> LookListSongs(Guid id_album);
        void SearchByAlbum(string nameGenre);
    }
}
