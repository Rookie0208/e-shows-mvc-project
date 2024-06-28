using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class Cinema
    {
        public int CId { get; set; }
        public string? CLogo { get; set; }
        public string? CName { get; set; }
        public string? CDescription { get; set; }
    }
}
