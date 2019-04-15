using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MoviesShop.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Country { get; set; }

        public List<MainActors> MainActors { get; set; }
    }
}
