using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class Producer
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PImageUrl { get; set; }
        public string? PBio { get; set; }
    }
}
