using System.ComponentModel.DataAnnotations;

namespace MusicBandsApp.Data.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public double SongDuration { get; set; }
    }
}