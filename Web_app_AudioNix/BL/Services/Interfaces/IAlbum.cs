using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IAlbum
    {
        IEnumerable<SongDTO> LookListSongs(Guid id_album);
        
    }
}
