﻿using System;
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
    public class SongIMP : ISort<SongDTO> , IActionSong
    {
        private readonly IMapper _mapper;
        UnityOfWork unityOfWork = new UnityOfWork();
        

        public SongIMP()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper= mappingConfig.CreateMapper();
        }
        public IEnumerable<SongDTO> GetAll()
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetList());

            return list;
        }

     
        public IEnumerable<SongDTO> SortByDesc()
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetList());

            var sortedlist = list.OrderByDescending(l => l.Name_of_song);

            return sortedlist;
        }

        public IEnumerable<SongDTO> SortByInc()
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.GenresRep.GetList());

            var sortedlist = list.OrderBy(l => l.Name_of_song);

            return sortedlist;
        }
        public IEnumerable<Genres_of_MusicDTO> SearchByGenre(Guid id_genre)
        {
            var listGenresSongs = _mapper.Map<List<Genres_of_MusicDTO>>(unityOfWork.Genres_of_MusicRep.GetList());

            var listsongs = from lstGenre in listGenresSongs
                            where lstGenre.GenreNavigation.GenreId == id_genre
                            select lstGenre;

            return listsongs;
        }

        public IEnumerable<SongDTO> SearchSong(string nameSong)
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetList());

            var searchlist = from lst in list
                             where lst.Name_of_song.StartsWith(nameSong) //еще возможно Contains 
                             select lst;
            return searchlist;
        }

        public IEnumerable<SongDTO> SortByDate()
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.GenresRep.GetList());

            var sortedlist = list.OrderBy(l => l.Date_of_release);

            return sortedlist;
        }

        //public IEnumerable<SongDTO> SortMostPopular() ============ в процессе
        //{
        //    var list = _mapper.Map<List<Playlist_of_UserDTO>>(unityOfWork.Playlist_of_UserRep.GetList());

        //    var sorted_list = list.GroupBy(x => x.SongId).Select(d => d.Count());

        //}

        public SongDTO ViewSong(Guid id_song)
        {
            var list = _mapper.Map<List<SongDTO>>(unityOfWork.SongsRep.GetList());

            var profile = list.Find(l => l.SongId == id_song);

            return profile;
        }
    }
}
