using System;
using System.Collections.Generic;
using System.Text;
using DL.Repository;
using DL.Entities;

namespace DL
{
    public class UnityOfWork 
    {
        private ApplicationContext db;

        public UnityOfWork(ApplicationContext db)
        {
            this.db = db;
        }
        AlbumRepository albumRepository;
        GenreRepository genreRepository;
        SongRepository songsRepository;
        PlaylistRepository playlistRepository;
        SingerRepository singerRepository;
        UserRepository userRepository;

        Genres_of_MusicRepository genreMusicRepository;
        Playlist_of_UserRepository playlist_Of_UserRepository;
        public AlbumRepository AlbumsRep
        {
            get
            {
                if (albumRepository == null)
                    albumRepository = new AlbumRepository(db);
                return albumRepository;
            }
        }
        public SongRepository SongsRep
        {
            get
            {
                if (songsRepository == null)
                    songsRepository = new SongRepository(db);
                return songsRepository;
            }
        }
        public GenreRepository GenresRep
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(db);
                return genreRepository;
            }
        }
        public PlaylistRepository PlaylistRep
        {
            get
            {
                if (playlistRepository == null)
                    playlistRepository = new PlaylistRepository(db);
                return playlistRepository;
            }
        }
        public SingerRepository SingerRep
        {
            get
            {
                if (singerRepository == null)
                    singerRepository = new SingerRepository(db);
                return singerRepository;
            }
        }
        public UserRepository UserRep
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public Genres_of_MusicRepository Genres_of_MusicRep
        {
            get
            {
                if (genreMusicRepository == null)
                    genreMusicRepository = new Genres_of_MusicRepository(db);
                return genreMusicRepository;
            }
        }
        public Playlist_of_UserRepository Playlist_of_UserRep
        {
            get
            {
                if (playlist_Of_UserRepository == null)
                    playlist_Of_UserRepository = new Playlist_of_UserRepository(db);
                return playlist_Of_UserRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }


    }
}
