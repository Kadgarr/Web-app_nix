using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IActionAlbum
    {
        IEnumerable<SongDTO> LookListSongs(Guid id_album);
        
    }
}
