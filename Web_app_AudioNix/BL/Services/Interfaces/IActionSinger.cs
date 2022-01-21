using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IActionSinger
    {
        IEnumerable<SongDTO> SearchBySinger(string nameSinger);
        SingerDTO ViewSinger(Guid id_singer);

    }
}
