using System;
using System.Collections.Generic;
using System.Text;
namespace BL.Services.Interfaces
{
    interface IGenre
    {
        IEnumerable<> SortByInc();
        void SortByDesc();
        void SearchByGenre();

    }
}
