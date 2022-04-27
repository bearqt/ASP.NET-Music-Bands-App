using System.ComponentModel.DataAnnotations.Schema;

namespace MusicBandsApp.Data.Models
{
    public class AlbumSong
    {
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        
        [ForeignKey("Song")]
        public int SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}