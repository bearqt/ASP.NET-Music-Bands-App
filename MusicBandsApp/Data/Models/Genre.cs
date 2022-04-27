using System.ComponentModel.DataAnnotations;

namespace MusicBandsApp.Data.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}