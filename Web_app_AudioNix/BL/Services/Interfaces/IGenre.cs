using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;
namespace BL.Services.Interfaces
{
    interface IGenre
    {
        IEnumerable<Genre> SortByInc();
        IEnumerable<Genre> SortByDesc();
        IEnumerable<Genre> SearchByGenre(string nameGenre);
        IEnumerable<Genre> GetAll();

    }
}
