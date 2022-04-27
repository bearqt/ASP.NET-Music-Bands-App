using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicBandsApp.Data.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        
        public string GroupName { get; set; }
    }
}