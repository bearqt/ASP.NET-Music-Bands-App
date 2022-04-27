using MusicBandsApp.Data.Models;

namespace MusicBandsApp.Services.Dto
{
    public class ArtistDto
    {
        public int? ArtistId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        
        public string ArtistSiteUrl { get; set; }
    }
}