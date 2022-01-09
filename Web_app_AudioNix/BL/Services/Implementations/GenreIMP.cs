using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL.Repository;
using DL.Entities;

namespace BL.Services.Implementations
{
    public class GenreIMP : ISort<GenreDTO> 
    {
        private readonly IMapper _mapper;
        GenreRepository genreRepository = new GenreRepository();
        

        public GenreIMP()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper= mappingConfig.CreateMapper();
        }
        public IEnumerable<GenreDTO> GetAll()
        {
            var list = _mapper.Map<List<GenreDTO>>(genreRepository.GetList());

            return list;
        }

        //public IEnumerable<GenreDTO> SearchByItem(string item)
        //{
        //    var list = _mapper.Map<List<GenreDTO>>(genreRepository.GetList());

        //    var genre = list.Find(itm=>itm.Name_of_Genre==item);

        //    var listGenresSongs = _mapper.Map<List<Genres_of_MusicDTO>>(gomrepos.GetList());

        //}

        public IEnumerable<GenreDTO> SortByDesc()
        {
            var list = _mapper.Map<List<GenreDTO>>(genreRepository.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_Genre);

            return sortedlist;
        }

        public IEnumerable<GenreDTO> SortByInc()
        {
            var list = _mapper.Map<List<GenreDTO>>(genreRepository.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_Genre);

            return sortedlist;
        }
    }
}
