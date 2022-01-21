using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL;

namespace BL.Services.Implementations
{
    public class GenreIMP : ISort<GenreDTO> 
    {
        private readonly IMapper _mapper;
        UnityOfWork unityOfWork = new UnityOfWork();
        

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
            var list = _mapper.Map<List<GenreDTO>>(unityOfWork.GenresRep.GetList());

            return list;
        }

        

        public IEnumerable<GenreDTO> SortByDesc()
        {
            var list = _mapper.Map<List<GenreDTO>>(unityOfWork.GenresRep.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_Genre);

            return sortedlist;
        }

        public IEnumerable<GenreDTO> SortByInc()
        {
            var list = _mapper.Map<List<GenreDTO>>(unityOfWork.GenresRep.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_Genre);

            return sortedlist;
        }
    }
}
