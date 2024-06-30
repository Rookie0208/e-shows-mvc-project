using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class LocationDetail
    {
        public int LcId { get; set; }
        public string? LcName { get; set; }
        public string? LcCountry { get; set; }
        public DateTime? LcCdt { get; set; }
        public DateTime? LcMdt { get; set; }
        public bool? LcIsActive { get; set; }
    }
}
