using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;
using BL.DtoEntities;

namespace BL.Mapping
{
    public class AutoMapperProfileBL_to_DL : Profile
    {
        public AutoMapperProfileBL_to_DL()
        {
            CreateMap<UserDTO,User>()/*.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))*/;
            CreateMap<AlbumDTO,Album>()/*.ForMember(dest => dest.AlbumId, opt => opt.MapFrom(src => src.AlbumId))
                .ForMember(dest => dest.Name_of_album, opt => opt.MapFrom(src => src.Name_of_album))
                .ForMember(dest => dest.Date_of_release, opt => opt.MapFrom(src => src.Date_of_release))
                .ForMember(dest => dest.SingerNavigation, opt => opt.MapFrom(src => src.SingerNavigation))*/; 
            CreateMap<GenreDTO,Genre>()/*.formember(dest => dest.genreid, opt => opt.mapfrom(src => src.genreid))
                .formember(dest => dest.name_of_genre, opt => opt.mapfrom(src => src.name_of_genre))*/;
            CreateMap<SingerDTO,Singer>()/*.ForMember(dest => dest.SingerId, opt => opt.MapFrom(src => src.SingerId))
                .ForMember(dest => dest.Name_of_singer, opt => opt.MapFrom(src => src.Name_of_singer))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Songs, opt => opt.MapFrom(src => src.Songs))
                .ForMember(dest => dest.Albums, opt => opt.MapFrom(src => src.Albums))*/;
            CreateMap<SongDTO,Song>()/*.ForMember(dest => dest.SongId, opt => opt.MapFrom(src => src.SongId))
                .ForMember(dest => dest.Name_of_song, opt => opt.MapFrom(src => src.Name_of_song))
                .ForMember(dest => dest.Date_of_release, opt => opt.MapFrom(src => src.Date_of_release))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.Genres_music, opt => opt.MapFrom(src => src.Genres_music))
                .ForMember(dest => dest.IdAlbumNavigation, opt => opt.MapFrom(src => src.IdAlbumNavigation))
                .ForMember(dest => dest.IdSingerNavigation, opt => opt.MapFrom(src => src.IdSingerNavigation))*/;
            CreateMap<PlaylistDTO,Playlist>()/*.ForMember(dest => dest.PlaylistId, opt => opt.MapFrom(src => src.PlaylistId))
                .ForMember(dest => dest.LikeCheck, opt => opt.MapFrom(src => src.LikeCheck))
                .ForMember(dest => dest.Name_of_playlist, opt => opt.MapFrom(src => src.Name_of_playlist))*/;
            CreateMap<Genres_of_MusicDTO,Genres_of_Music>()/*.ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => src.GenreId))
                .ForMember(dest => dest.SongId, opt => opt.MapFrom(src => src.SongId))
                .ForMember(dest => dest.GenreNavigation, opt => opt.MapFrom(src => src.GenreNavigation))
                .ForMember(dest => dest.SongNavigation, opt => opt.MapFrom(src => src.SongNavigation))*/;
            CreateMap<Playlist_of_UserDTO,Playlist_of_User>()/*.ForMember(dest => dest.PlaylistId, opt => opt.MapFrom(src => src.PlaylistId))
                .ForMember(dest => dest.SongId, opt => opt.MapFrom(src => src.SongId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserNavigation, opt => opt.MapFrom(src => src.UserNavigation))
                .ForMember(dest => dest.SongNavigation, opt => opt.MapFrom(src => src.SongNavigation))
                .ForMember(dest => dest.PlaylistNavigation, opt => opt.MapFrom(src => src.PlaylistNavigation))*/;
        }
    }
}
