using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IAlbum
    {
        IEnumerable<AlbumDTO> LookListSongs(Guid id_album);
        void SearchByAlbum(string name);
    }
}
