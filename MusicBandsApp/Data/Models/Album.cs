using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicBandsApp.Data.Models
{
    public class Album
    {
        public Album()
        {
            this.SongsIncluded = new HashSet<AlbumSong>(); // точно надо
        }
        
        [Key]
        public int AlbumId { get; set; }
        
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        
        public string AlbumTitle { get; set; }
        public int AlbumYear { get; set; }
        public virtual ICollection<AlbumSong> SongsIncluded { get; set; }
    }
}