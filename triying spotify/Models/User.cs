using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace triying_spotify.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string UserName { get; set; }
        
        [Required, StringLength(100), Display(Name = "Email")]
        public string UserEmail { get; set; }

        public virtual ICollection<Song> Songs { get; set;}

    }
}