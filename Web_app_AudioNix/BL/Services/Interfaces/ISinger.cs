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
        IEnumerable<Genre> SortByInc();C:\Users\MAXIM\source\Web-app_nix\Web_app_AudioNix\BL\Services\Interfaces\ISinger.cs
        IEnumerable<Genre> SortByDesc();
    }
}
