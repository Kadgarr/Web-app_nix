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
using System.Threading.Tasks;

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
          
        }

        public async Task<IEnumerable<GenreDTO>> GetAll()
        {
            var list = _mapper.Map<List<GenreDTO>>(await unityOfWork.GenresRep.GetListAsync());

            return list;
        }


        public async Task<IEnumerable<GenreDTO>> SortByDesc()
        {
            var list = _mapper.Map<List<GenreDTO>>(await unityOfWork.GenresRep.GetListAsync());

            var sortedlist = list.OrderByDescending(l => l.Name_of_Genre);

            return sortedlist;
        }

        public async Task<IEnumerable<GenreDTO>> SortByInc()
        {
            var list = _mapper.Map<List<GenreDTO>>(await unityOfWork.GenresRep.GetListAsync());

            var sortedlist = list.OrderBy(l => l.Name_of_Genre);

            return sortedlist;
        }


        public void AddGenre(string Name_of_genre)
        {
            var genreDTO = new GenreDTO { GenreId = new Guid(), Name_of_Genre = Name_of_genre };
            var genre = _mapper.Map<Genre>(genreDTO);
            unityOfWork.GenresRep.Add(genre);
        }

        public async Task EditGenre(GenreDTO genreDTO)
        {
            var genre = _mapper.Map<Genre>(genreDTO);
           await unityOfWork.GenresRep.ChangeAsync(genre.GenreId);
        }

        public async Task RemoveGenre(GenreDTO genreDTO)
        {
            var genre = _mapper.Map<Genre>(genreDTO);

            await unityOfWork.GenresRep.DeleteAsync(genre.GenreId);
        }

        public async Task<GenreDTO> GetItemAsync(Guid id)
        {
            return _mapper.Map<GenreDTO>(await unityOfWork.GenresRep.GetItemAsync(id));
        }
    }
}
