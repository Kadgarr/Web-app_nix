using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using BL.Mapping;
using DL.Repository;
using DL.Entities;

namespace BL.Services.Implementations
{
    public class SortGenre : ISort<GenreDTO>
    {
        private readonly IMapper _mapper;
        GenreRepository genreRepository = new GenreRepository();

        public SortGenre(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<GenreDTO> GetAll()
        {
            var list = _mapper.Map<List<GenreDTO>>(genreRepository.GetList());

            return list;
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
