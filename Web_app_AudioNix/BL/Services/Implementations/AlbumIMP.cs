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
    public class AlbumIMP:IAlbum, ISort<AlbumDTO>
    {
        private readonly IMapper _mapper;
        AlbumRepository albumRepository = new AlbumRepository();
        SongsRepository songsRepository = new SongsRepository();

        public AlbumIMP()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();
        }

        public IEnumerable<AlbumDTO> SortByDesc()
        {
            var list = _mapper.Map<List<AlbumDTO>>(albumRepository.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_album);

            return sortedlist;
        }

        public IEnumerable<AlbumDTO> SortByInc()
        {
            var list = _mapper.Map<List<AlbumDTO>>(albumRepository.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_album);

            return sortedlist;
        }
        public IEnumerable<AlbumDTO> GetAll()
        {
            var list = _mapper.Map<List<AlbumDTO>>(albumRepository.GetList());

            return list;
        }

        public IEnumerable<SongDTO> LookListSongs(Guid id_album)
        {
            var list = _mapper.Map<List<AlbumDTO>>(albumRepository.GetList());

            var album = list.Find(itm=>itm.AlbumId== id_album);

            var songs = _mapper.Map<List<SongDTO>>(songsRepository.GetList());

            var listsongsalbum = from lst in list
                                 from sngs in songs
                                 where album.AlbumId == sngs.IdAlbumNavigation.AlbumId
                                 select sngs;

            return listsongsalbum;

        }



    }
}
