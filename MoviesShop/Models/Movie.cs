using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MoviesShop.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string ProductionCompany { get; set; }
        public string Country { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        //age
        public List<MainActors> MainActors { get; set; }
        public Genre Genre { get; set; }
    }
}
