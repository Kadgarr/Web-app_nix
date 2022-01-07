using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;
namespace BL.Services.Interfaces
{
    interface ISort<T> where T:class
    {
        IEnumerable<T> SortByInc();
        IEnumerable<T> SortByDesc();
        IEnumerable<T> SearchByItem(string name);
        IEnumerable<T> GetAll();

    }
}
