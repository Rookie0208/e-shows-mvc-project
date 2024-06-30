using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_shows.Models
{
    public partial class Producer
    {
        public int PId { get; set; }

        [DisplayName("Producer Name")]
        public string? PName { get; set; }

        [DisplayName("Producer Image")]
        public string? PImageUrl { get; set; }


        [DisplayName("Producer Bio")]
        public string? PBio { get; set; }
    }
}
