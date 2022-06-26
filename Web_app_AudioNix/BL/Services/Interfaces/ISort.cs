using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BL.DtoEntities;
namespace BL.Services.Interfaces
{
    interface ISort<T> where T:class 
    {
        Task<IEnumerable<T>> SortByInc();
        Task<IEnumerable<T>> SortByDesc();
        Task<IEnumerable<T>> GetAll();

    }
}
