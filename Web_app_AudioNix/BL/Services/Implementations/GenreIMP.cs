using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL.Entities;
using DL;

namespace BL.Services.Implementations
{
    public class GenreIMP : ISort<GenreDTO> 
    {
        private readonly IMapper _mapper;
        private readonly IMapper _mapper_bl_dl;
        private UnityOfWork unityOfWork;

        public GenreIMP(ApplicationContext db)
        {
            unityOfWork = new UnityOfWork(db);
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();
            var mappingConfig2 = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper_bl_dl = mappingConfig2.CreateMapper();
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


        public void AddGenre(string Name_of_genre)
        {
            var genreDTO = new GenreDTO { GenreId = new Guid(), Name_of_Genre = Name_of_genre };
            var genre = _mapper_bl_dl.Map<Genre>(genreDTO);
            unityOfWork.GenresRep.Add(genre);
        }

        public void EditGenre(GenreDTO genreDTO)
        {
            var genre = _mapper_bl_dl.Map<Genre>(genreDTO);
            unityOfWork.GenresRep.Change(genre);
        }

        public void RemoveGenre(GenreDTO genreDTO)
        {
            var genre = _mapper_bl_dl.Map<Genre>(genreDTO);
            unityOfWork.GenresRep.Delete(genre);
        }

    }
}
