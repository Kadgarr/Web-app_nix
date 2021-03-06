using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using DL.Entities;

namespace DL
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Genres_of_Music> Genres_of_Music { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Playlist_of_User> Playlist_of_User { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        //  public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=WebAppNix_DB;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.Entity<Playlist_of_User>().HasNoKey();

            builder.Entity<Playlist_of_User>(entity =>
            {
                entity.HasKey(e => e.id_record);

                entity.HasOne(k => k.UserNavigation).WithMany(k => k.Playlists_Of_User)

                 ;
            });
            
           
            base.OnModelCreating(builder);
        }

    }
}
