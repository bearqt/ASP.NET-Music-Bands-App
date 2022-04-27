using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicBandsApp.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Artists = new HashSet<Artist>();
        }
        
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Artist> Artists { get; set; }
    }
}