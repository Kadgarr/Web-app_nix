using System;
using System.Collections.Generic;
using System.Text;
using BL.Services.Interfaces;
using BL.DtoEntities;
using AutoMapper;
using System.Linq;
using BL.Mapping;
using DL;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class AlbumIMP:IActionAlbum, ISort<AlbumDTO>
    {
        private readonly IMapper _mapper;

        private UnityOfWork unityOfWork;
        
        public AlbumIMP(ApplicationContext db)
        {
            unityOfWork = new UnityOfWork(db);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();
        }

        public async Task<IEnumerable<AlbumDTO>> SortByDesc()
        {
            var list = _mapper.Map<List<AlbumDTO>>(await unityOfWork.AlbumsRep.GetListAsync());

            var sortedlist = list.OrderByDescending(l => l.Name_of_album);

            return sortedlist;
        }

        public async Task<IEnumerable<AlbumDTO>> SortByInc()
        {
            var list = _mapper.Map<List<AlbumDTO>>(await unityOfWork.AlbumsRep.GetListAsync());

            var sortedlist = list.OrderBy(l => l.Name_of_album);

            return sortedlist;
        }
        public async Task<IEnumerable<AlbumDTO>> GetAll()
        {
            var list = _mapper.Map<List<AlbumDTO>>(await unityOfWork.AlbumsRep.GetListAsync());

            return list;
        }

        public IEnumerable<SongDTO> LookListSongs(Guid id_album)
        {
            var list = _mapper.Map<List<AlbumDTO>>(unityOfWork.AlbumsRep.GetListAsync());

            var album = list.Find(itm=>itm.AlbumId== id_album);

            var songs = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetListAsync());

            var listsongsalbum = from lst in list
                                 from sngs in songs
                                 where sngs.IdAlbumNavigation.AlbumId == album.AlbumId
                                 select sngs;

            return listsongsalbum;

        }



    }
}
