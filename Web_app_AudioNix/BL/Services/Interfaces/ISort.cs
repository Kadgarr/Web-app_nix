using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface ISort<T> where T:class 
    {
        IEnumerable<T> SortByInc();
        IEnumerable<T> SortByDesc();
        IEnumerable<T> GetAll();

    }
}
