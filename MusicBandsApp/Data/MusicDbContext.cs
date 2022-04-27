using Microsoft.EntityFrameworkCore;
using MusicBandsApp.Data.Models;

namespace MusicBandsApp.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext()
        {
        }
        
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=MusicApp; Integrated Security=True;");
            }
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data
            modelBuilder.Entity<Country>().HasData(
                new Country() {CountryId = 1, Name = "Country1"},
                new Country() {CountryId = 2, Name = "Country2"},
                new Country() {CountryId = 3, Name = "Country3"},
                new Country() {CountryId = 4, Name = "Country4"},
                new Country() {CountryId = 5, Name = "Country5"},
                new Country() {CountryId = 6, Name = "Country6"},
                new Country() {CountryId = 7, Name = "Country7"});

            modelBuilder.Entity<Genre>().HasData(
                new Genre() {GenreId = 1, Name = "Pop"},
                new Genre() {GenreId = 2, Name = "Rock"},
                new Genre() {GenreId = 3, Name = "Blues"},
                new Genre() {GenreId = 4, Name = "Rap"},
                new Genre() {GenreId = 5, Name = "Classic"});

            modelBuilder.Entity<Artist>().HasData(
                new Artist() {ArtistId = 1, GenreId = 1, CountryId = 1, FirstName = "FirstName1", LastName = "LastName1", ArtistSiteUrl = "my.url.com"},
                new Artist() {ArtistId = 2, GenreId = 2, CountryId = 2, FirstName = "FirstName2", LastName = "LastName2", ArtistSiteUrl = "my.url.com"},
                new Artist() {ArtistId = 3, GenreId = 3, CountryId = 3, FirstName = "FirstName3", LastName = "LastName3", ArtistSiteUrl = "my.url.com"},
                new Artist() {ArtistId = 4, GenreId = 4, CountryId = 4, FirstName = "FirstName4", LastName = "LastName4", ArtistSiteUrl = "my.url.com"},
                new Artist() {ArtistId = 5, GenreId = 5, CountryId = 5, FirstName = "FirstName5", LastName = "LastName5", ArtistSiteUrl = "my.url.com"});

            modelBuilder.Entity<Group>().HasData(
                new Group() {GroupId = 1, ArtistId = 1, GroupName = "GroupName1"},
                new Group() {GroupId = 2, ArtistId = 2, GroupName = "GroupName2"},
                new Group() {GroupId = 3, ArtistId = 3, GroupName = "GroupName3"},
                new Group() {GroupId = 4, ArtistId = 4, GroupName = "GroupName4"},
                new Group() {GroupId = 5, ArtistId = 5, GroupName = "GroupName5"});

            modelBuilder.Entity<Song>().HasData(
                new Song() {SongId = 1, SongTitle = "SongTitle1", SongDuration = 1},
                new Song() {SongId = 2, SongTitle = "SongTitle2", SongDuration = 2},
                new Song() {SongId = 3, SongTitle = "SongTitle3", SongDuration = 3},
                new Song() {SongId = 4, SongTitle = "SongTitle4", SongDuration = 4},
                new Song() {SongId = 5, SongTitle = "SongTitle5", SongDuration = 5});

            modelBuilder.Entity<Album>().HasData(
                new Album() {AlbumId = 1, ArtistId = 1, AlbumTitle = "AlbumTitle1", AlbumYear = 1},
                new Album() {AlbumId = 2, ArtistId = 2, AlbumTitle = "AlbumTitle2", AlbumYear = 2},
                new Album() {AlbumId = 3, ArtistId = 3, AlbumTitle = "AlbumTitle3", AlbumYear = 3},
                new Album() {AlbumId = 4, ArtistId = 4, AlbumTitle = "AlbumTitle4", AlbumYear = 4},
                new Album() {AlbumId = 5, ArtistId = 5, AlbumTitle = "AlbumTitle5", AlbumYear = 5});

            modelBuilder.Entity<AlbumSong>().HasData(
                new AlbumSong() {AlbumId = 1, SongId = 1},
                new AlbumSong() {AlbumId = 2, SongId = 2},
                new AlbumSong() {AlbumId = 3, SongId = 3},
                new AlbumSong() {AlbumId = 4, SongId = 4},
                new AlbumSong() {AlbumId = 5, SongId = 5});
            
            modelBuilder.Entity<AlbumSong>(entity =>
            {
                entity.HasKey(al => new {al.AlbumId, al.SongId});
            });

            modelBuilder.Entity<Artist>()
                .HasOne(a => a.Country)
                .WithMany(c => c.Artists);
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<AlbumSong> AlbumSongs { get; set; }
        
    }
}