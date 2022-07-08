﻿// <auto-generated />
using System;
using DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220708092730_UpdateUserName")]
    partial class UpdateUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1, 1);

            modelBuilder.Entity("DL.Entities.Album", b =>
                {
                    b.Property<Guid>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date_of_release")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdSinger")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_of_album")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SingerNavigationSingerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AlbumId");

                    b.HasIndex("SingerNavigationSingerId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("DL.Entities.Genre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_of_Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("DL.Entities.Genres_of_Music", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("SongId");

                    b.ToTable("Genres_of_Music");
                });

            modelBuilder.Entity("DL.Entities.Playlist", b =>
                {
                    b.Property<Guid>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LikeCheck")
                        .HasColumnType("bit");

                    b.Property<string>("Name_of_playlist")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("DL.Entities.Playlist_of_User", b =>
                {
                    b.Property<Guid>("id_record")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PlaylistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserNavigationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id_record");

                    b.HasIndex("PlaylistId");

                    b.HasIndex("SongId");

                    b.HasIndex("UserNavigationId");

                    b.ToTable("Playlist_of_User");
                });

            modelBuilder.Entity("DL.Entities.Singer", b =>
                {
                    b.Property<Guid>("SingerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_of_singer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SingerId");

                    b.ToTable("Singers");
                });

            modelBuilder.Entity("DL.Entities.Song", b =>
                {
                    b.Property<Guid>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date_of_release")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdAlbumNavigationAlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSingerNavigationSingerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_of_song")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("IdAlbumNavigationAlbumId");

                    b.HasIndex("IdSingerNavigationSingerId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("DL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_of_registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PasswordConfirm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DL.Entities.Album", b =>
                {
                    b.HasOne("DL.Entities.Singer", "SingerNavigation")
                        .WithMany("Albums")
                        .HasForeignKey("SingerNavigationSingerId");

                    b.Navigation("SingerNavigation");
                });

            modelBuilder.Entity("DL.Entities.Genres_of_Music", b =>
                {
                    b.HasOne("DL.Entities.Genre", "GenreNavigation")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.HasOne("DL.Entities.Song", "SongNavigation")
                        .WithMany("Genres_music")
                        .HasForeignKey("SongId");

                    b.Navigation("GenreNavigation");

                    b.Navigation("SongNavigation");
                });

            modelBuilder.Entity("DL.Entities.Playlist_of_User", b =>
                {
                    b.HasOne("DL.Entities.Playlist", "PlaylistNavigation")
                        .WithMany()
                        .HasForeignKey("PlaylistId");

                    b.HasOne("DL.Entities.Song", "SongNavigation")
                        .WithMany()
                        .HasForeignKey("SongId");

                    b.HasOne("DL.Entities.User", "UserNavigation")
                        .WithMany("Playlists_Of_User")
                        .HasForeignKey("UserNavigationId");

                    b.Navigation("PlaylistNavigation");

                    b.Navigation("SongNavigation");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("DL.Entities.Song", b =>
                {
                    b.HasOne("DL.Entities.Album", "IdAlbumNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdAlbumNavigationAlbumId");

                    b.HasOne("DL.Entities.Singer", "IdSingerNavigation")
                        .WithMany("Songs")
                        .HasForeignKey("IdSingerNavigationSingerId");

                    b.Navigation("IdAlbumNavigation");

                    b.Navigation("IdSingerNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DL.Entities.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DL.Entities.Singer", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DL.Entities.Song", b =>
                {
                    b.Navigation("Genres_music");
                });

            modelBuilder.Entity("DL.Entities.User", b =>
                {
                    b.Navigation("Playlists_Of_User");
                });
#pragma warning restore 612, 618
        }
    }
}
