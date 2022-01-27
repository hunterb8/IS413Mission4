using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class NewMovie
    {
        [Key]
        [Required]
        public int film_id { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent_to { get; set; }
        public string notes { get; set; }
    }
}
