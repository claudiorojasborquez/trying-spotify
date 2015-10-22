using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace triying_spotify.Models
{
    public class Artist
    {
        [ScaffoldColumn(false)]
        public int ArtistID { get; set; }

        [Required, Display(Name = "Artist Name")]
        public string ArtistName { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}