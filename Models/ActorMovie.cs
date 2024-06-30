using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class ActorMovie
    {
        public int? MId { get; set; }
        public int? ActId { get; set; }
        public int AmId { get; set; }

        public virtual Actor Am { get; set; } = null!;
        public virtual Movie? MIdNavigation { get; set; }
    }
}
