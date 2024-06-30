using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace e_shows.Models
{
    public partial class Cinema
    {
        public int CId { get; set; }

        [DisplayName("Cinema Logo")]
        public string? CLogo { get; set; }

        [DisplayName("Cinema Name")]
        public string? CName { get; set; }

        [DisplayName("Cinema Description")]
        public string? CDescription { get; set; }
    }
}
