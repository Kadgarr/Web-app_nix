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
    public class PlaylistIMP : ISort<PlaylistDTO>, IPlaylist 
    {
        private readonly IMapper _mapper;
        private UnityOfWork unityOfWork;

        public PlaylistIMP(ApplicationContext db)
        {
            unityOfWork = new UnityOfWork(db);
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper= mappingConfig.CreateMapper();
        }

        
        public IEnumerable<PlaylistDTO> GetAll()
        {
            var list = _mapper.Map<List<PlaylistDTO>>(unityOfWork.PlaylistRep.GetList());

            return list;
        }

       
        public IEnumerable<PlaylistDTO> SortByDesc()
        {
            var list = _mapper.Map<List<PlaylistDTO>>(unityOfWork.PlaylistRep.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_playlist);

            return sortedlist;
        }
        public IEnumerable<PlaylistDTO> SortByInc()
        {
            var list = _mapper.Map<List<PlaylistDTO>>(unityOfWork.PlaylistRep.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_playlist);

            return sortedlist;
        }

     
        public IEnumerable<Playlist_of_UserDTO> SearchByUser(Guid userId)
        {
            var list = _mapper.Map<List<Playlist_of_UserDTO>>(unityOfWork.Playlist_of_UserRep.GetList());

            var playlists = list.Where(x => x.UserId == userId);
            return playlists;

        }
        public IEnumerable<PlaylistDTO> SortByFavourite()
        {
            var list = _mapper.Map<List<PlaylistDTO>>(unityOfWork.PlaylistRep.GetList());

            var sortedlist = list.OrderBy(l => l.LikeCheck);

            return sortedlist;
        }

        public PlaylistDTO ViewPlaylist(Guid id_playlist)
        {
            var list = _mapper.Map<List<PlaylistDTO>>(unityOfWork.PlaylistRep.GetList());

            var playlist = list.Find(l => l.PlaylistId == id_playlist);
            return playlist;
        }
    }
}
