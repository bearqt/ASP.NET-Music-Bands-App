﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicBandsApp.Data;

namespace MusicBandsApp.Data.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20220425172903_AddedNewSeedData")]
    partial class AddedNewSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MusicBandsApp.Data.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AlbumTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AlbumYear")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.AlbumSong", b =>
                {
                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("AlbumId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("AlbumSongs");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ArtistSiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.HasIndex("CountryId");

                    b.HasIndex("GenreId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            ArtistSiteUrl = "my.url.com",
                            CountryId = 1,
                            FirstName = "FirstName1",
                            GenreId = 1,
                            LastName = "LastName1"
                        },
                        new
                        {
                            ArtistId = 2,
                            ArtistSiteUrl = "my.url.com",
                            CountryId = 2,
                            FirstName = "FirstName2",
                            GenreId = 2,
                            LastName = "LastName2"
                        },
                        new
                        {
                            ArtistId = 3,
                            ArtistSiteUrl = "my.url.com",
                            CountryId = 3,
                            FirstName = "FirstName3",
                            GenreId = 3,
                            LastName = "LastName3"
                        },
                        new
                        {
                            ArtistId = 4,
                            ArtistSiteUrl = "my.url.com",
                            CountryId = 4,
                            FirstName = "FirstName4",
                            GenreId = 4,
                            LastName = "LastName4"
                        },
                        new
                        {
                            ArtistId = 5,
                            ArtistSiteUrl = "my.url.com",
                            CountryId = 5,
                            FirstName = "FirstName5",
                            GenreId = 5,
                            LastName = "LastName5"
                        });
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Country1"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Country2"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Country3"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "Country4"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Country5"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "Country6"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "Country7"
                        });
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Pop"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Rock"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Blues"
                        },
                        new
                        {
                            GenreId = 4,
                            Name = "Rap"
                        },
                        new
                        {
                            GenreId = 5,
                            Name = "Classic"
                        });
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("SongDuration")
                        .HasColumnType("float");

                    b.Property<string>("SongTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Album", b =>
                {
                    b.HasOne("MusicBandsApp.Data.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.AlbumSong", b =>
                {
                    b.HasOne("MusicBandsApp.Data.Models.Album", "Album")
                        .WithMany("SongsIncluded")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicBandsApp.Data.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Artist", b =>
                {
                    b.HasOne("MusicBandsApp.Data.Models.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicBandsApp.Data.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Group", b =>
                {
                    b.HasOne("MusicBandsApp.Data.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Album", b =>
                {
                    b.Navigation("SongsIncluded");
                });

            modelBuilder.Entity("MusicBandsApp.Data.Models.Country", b =>
                {
                    b.Navigation("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}