using System.Collections.Generic;
using System.Linq;
using MusicBandsApp.Data.Models;

namespace MusicBandsApp.Data
{
    public class DbSeeder
    {
        public static void SeedData(MusicDbContext context)
        {
            if (context.Artists.Any())
            {
                return;
            }
            context.Genres.AddRange(GetGenres());
            context.Countries.AddRange(GetCountries());
            context.SaveChanges();
            
            context.Artists.AddRange(GetArtists());
            context.SaveChanges();
            
            context.Groups.AddRange(GetGroups());
            context.Songs.AddRange(GetSongs());
            context.Albums.AddRange(GetAlbums());
            context.SaveChanges();
            
            context.AlbumSongs.AddRange(GetAlbumSongs());
            context.SaveChanges();
        }

        private static IList<Genre> GetGenres()
        {
            return new List<Genre>() 
            {
                new Genre() {Name = "Pop"},
                new Genre() {Name = "Rock"},
                new Genre() {Name = "Blues"},
                new Genre() {Name = "Rap"},
                new Genre() {Name = "Classic"},
            };
        }

        private static IList<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country() {Name = "Country1"},
                new Country() {Name = "Country2"},
                new Country() {Name = "Country3"},
                new Country() {Name = "Country4"},
                new Country() {Name = "Country5"},
                new Country() {Name = "Country6"},
                new Country() {Name = "Country7"},
            };
        }

        private static IList<Artist> GetArtists()
        {
            return new List<Artist>()
            {
                new Artist() {GenreId = 1, CountryId = 1, FirstName = "FirstName1", LastName = "LastName1", ArtistSiteUrl = "my.url.com"},
                new Artist() {GenreId = 2, CountryId = 2, FirstName = "FirstName2", LastName = "LastName2", ArtistSiteUrl = "my.url.com"},
                new Artist() {GenreId = 3, CountryId = 3, FirstName = "FirstName3", LastName = "LastName3", ArtistSiteUrl = "my.url.com"},
                new Artist() {GenreId = 4, CountryId = 4, FirstName = "FirstName4", LastName = "LastName4", ArtistSiteUrl = "my.url.com"},
                new Artist() {GenreId = 5, CountryId = 5, FirstName = "FirstName5", LastName = "LastName5", ArtistSiteUrl = "my.url.com"},
            };
        }

        private static IList<Group> GetGroups()
        {
            return new List<Group>()
            {
                new Group() {ArtistId = 1, GroupName = "GroupName1"},
                new Group() {ArtistId = 2, GroupName = "GroupName2"},
                new Group() {ArtistId = 3, GroupName = "GroupName3"},
                new Group() {ArtistId = 4, GroupName = "GroupName4"},
                new Group() {ArtistId = 5, GroupName = "GroupName5"},
            };
        }

        private static IList<Song> GetSongs()
        {
            return new List<Song>()
            {
                new Song() {SongTitle = "SongTitle1", SongDuration = 1},
                new Song() {SongTitle = "SongTitle2", SongDuration = 2},
                new Song() {SongTitle = "SongTitle3", SongDuration = 3},
                new Song() {SongTitle = "SongTitle4", SongDuration = 4},
                new Song() {SongTitle = "SongTitle5", SongDuration = 5},
            };
        }

        private static IList<Album> GetAlbums()
        {
            return new List<Album>()
            {
                new Album() {ArtistId = 1, AlbumTitle = "AlbumTitle1", AlbumYear = 1},
                new Album() {ArtistId = 2, AlbumTitle = "AlbumTitle2", AlbumYear = 2},
                new Album() {ArtistId = 3, AlbumTitle = "AlbumTitle3", AlbumYear = 3},
                new Album() {ArtistId = 4, AlbumTitle = "AlbumTitle4", AlbumYear = 4},
                new Album() {ArtistId = 5, AlbumTitle = "AlbumTitle5", AlbumYear = 5},
            };
        }

        private static IList<AlbumSong> GetAlbumSongs()
        {
            return new List<AlbumSong>()
            {
                new AlbumSong() {AlbumId = 1, SongId = 1},
                new AlbumSong() {AlbumId = 2, SongId = 2},
                new AlbumSong() {AlbumId = 3, SongId = 3},
                new AlbumSong() {AlbumId = 4, SongId = 4},
                new AlbumSong() {AlbumId = 5, SongId = 5},
            };
        }
    }
}