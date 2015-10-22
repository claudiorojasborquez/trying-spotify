using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace triying_spotify.Models
{
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumID { get; set; }

        [Required, Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        public string Description { get; set; }

        public DateTime Release { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }

    public class Song
    {
        [ScaffoldColumn(false)]
        public int SongID { get; set; }

        [Required, Display(Name ="Song Name")]
        public string SongName { get; set; }

        //The rating according to the spotify db
        public int Rating { get; set; }


        //How long the song is, convert to seconds using timestamp
        public double Length { get; set; }
    }
}