using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNetCore.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [EmailAddress]
        public String email { get; set; }
    }
}
    
