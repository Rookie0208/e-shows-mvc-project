using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class Actor
    {
        public int ActId { get; set; }
        public string? ActName { get; set; }
        public string? ActImageUrl { get; set; }
        public string? ActBio { get; set; }

        public virtual ActorMovie? ActorMovie { get; set; }
    }
}
