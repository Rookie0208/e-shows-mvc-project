using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class Artist
    {
        public int? ArtId { get; set; }
        public string? ArtName { get; set; }
        public string? ArtImageUrl { get; set; }
        public string? ArtBio { get; set; }
    }
}
