using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;

namespace BL.Services.Interfaces
{
    interface ISinger
    {
        IEnumerable<Singer> SearchBySinger(string nameSinger);
        void ViewSinger(Guid id_singer);

    }
}
