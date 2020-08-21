using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Lab21_MovieRegistration.Models
{
    public class Movie
    {
        [Required]
        public int ID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string[] Actors { get; set; }
        [Required]
        public string[] Directors { get; set; }

    }
}
