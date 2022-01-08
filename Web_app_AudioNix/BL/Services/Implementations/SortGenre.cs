using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
namespace BL.Services.Implementations
{
    public class SortGenre : ISort<GenreDTO>
    {
        public IEnumerable<GenreDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreDTO> SearchByItem(string item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreDTO> SortByDesc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreDTO> SortByInc()
        {
            throw new NotImplementedException();
        }
    }
}
