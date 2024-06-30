using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_shows.Models
{
    public partial class Actor
    {
        public int ActId { get; set; }

        [DisplayName("Actor Name")]
        public string? ActName { get; set; }

        [DisplayName("Actor Image")]
        public string? ActImageUrl { get; set; }

        [DisplayName("Actor Bio")]
        public string? ActBio { get; set; }

        public virtual ActorMovie? ActorMovie { get; set; }
    }
}
