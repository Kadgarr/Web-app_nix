using System;
using System.Collections.Generic;
using System.Text;
using DL.Repository;
using DL.Entities;

namespace DL
{
    public class UnityOfWork 
    {
        ApplicationContext db = new ApplicationContext();

        AlbumRepository albumRepository ;
        SongsRepository songsRepository ;
        GenreRepository genreRepository ;
        Genres_of_MusicRepository genreMusicRepository = new Genres_of_MusicRepository();

        public AlbumRepository AlbumsRep
        {
            get
            {
                if (albumRepository == null)
                    albumRepository = new AlbumRepository();
                return albumRepository;
            }
        }

        public SongsRepository SongsRep
        {
            get
            {
                if (songsRepository == null)
                    songsRepository = new SongsRepository();
                return songsRepository;
            }
        }
        public GenreRepository GenresRep
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository();
                return genreRepository;
            }
        }

        public Genres_of_MusicRepository OrdersRep
        {
            get
            {
                if (genreMusicRepository == null)
                    genreMusicRepository = new Genres_of_MusicRepository();
                return genreMusicRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }


    }
}
