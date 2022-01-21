using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface IActionSinger
    {
        IEnumerable<SingerDTO> SearchBySinger(string nameSinger);
        void ViewSinger(Guid id_singer);

    }
}
