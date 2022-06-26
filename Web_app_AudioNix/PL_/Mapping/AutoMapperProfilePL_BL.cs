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
            CreateMap<UserView, UserDTO>().ReverseMap();
            CreateMap<AlbumView, AlbumDTO>().ReverseMap(); 
            CreateMap<GenreView, GenreDTO>().ReverseMap();
            CreateMap<SingerView, SingerDTO>().ReverseMap();
            CreateMap<SongView, SongDTO>().ReverseMap();
            CreateMap<PlaylistView, PlaylistDTO>().ReverseMap();
            CreateMap<Genres_of_MusicView, Genres_of_MusicDTO>().ReverseMap();
            CreateMap<Playlist_of_UserView, Playlist_of_UserDTO>().ReverseMap();
        }
    }
}
