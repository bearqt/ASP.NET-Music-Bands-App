using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicBandsApp.Data.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; } 
        
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get;set; }

        public string ArtistSiteUrl { get; set; }
    }
}