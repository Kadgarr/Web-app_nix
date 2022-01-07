using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;

namespace BL.Services.Interfaces
{
    interface ISinger
    {
        IEnumerable<SingerDTO> SearchBySinger(string nameSinger);
        void ViewSinger(Guid id_singer);

    }
}
