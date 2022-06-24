using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using BL.DtoEntities;
using PL.Models;

namespace PL.Mapping
{
    public class AutoMapperProfilePL_BL : Profile
    {
        public AutoMapperProfilePL_BL()
        {
            CreateMap<UserView, UserDTO>();
            CreateMap<AlbumView, AlbumDTO>(); 
            CreateMap<GenreView, GenreDTO>();
            CreateMap<SingerView, SingerDTO>();
            CreateMap<SongView, SongDTO>();
            CreateMap<PlaylistView, PlaylistDTO>();
            CreateMap<Genres_of_MusicView, Genres_of_MusicDTO>();
            CreateMap<Playlist_of_UserView, Playlist_of_UserDTO>();
        }
    }
}
