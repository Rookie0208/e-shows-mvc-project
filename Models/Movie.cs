using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_shows.Models
{
    public partial class Movie
    {
        public Movie()
        {
            ActorMovies = new HashSet<ActorMovie>();
        }

        public int MId { get; set; }

        [DisplayName("Movie Name")]
        public string? MName { get; set; }

        [DisplayName("Movie Description")]
        public string? MDescription { get; set; }

        [DisplayName("Movie Price")]
        public decimal? MPrice { get; set; }

        [DisplayName("Movie Image")]
        public string? MImageUrl { get; set; }

        [DisplayName("Movie Start Date")]
        public DateTime? MStartDate { get; set; }

        [DisplayName("Movie End Date")]
        public DateTime? MEndDate { get; set; }

        [DisplayName("Movie Category")]
        public string? McCategory { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
