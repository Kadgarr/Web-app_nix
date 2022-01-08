using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DL.Entities;

namespace DL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Genres_of_Music> Genres_of_Music { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Playlist_of_User> Playlist_of_User { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAppNix_DB;Trusted_Connection=True;");
        }
    }
}
