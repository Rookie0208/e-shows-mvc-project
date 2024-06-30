using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class Movie
    {
        public Movie()
        {
            ActorMovies = new HashSet<ActorMovie>();
        }

        public int MId { get; set; }
        public string? MName { get; set; }
        public string? MDescription { get; set; }
        public decimal? MPrice { get; set; }
        public string? MImageUrl { get; set; }
        public DateTime? MStartDate { get; set; }
        public DateTime? MEndDate { get; set; }
        public string? McCategory { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
