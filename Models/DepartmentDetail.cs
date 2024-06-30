using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class DepartmentDetail
    {
        public int DpId { get; set; }
        public string? DpName { get; set; }
        public DateTime? DpCdt { get; set; }
        public DateTime? DpMdt { get; set; }
        public bool? DpIsActive { get; set; }
        public int? LcId { get; set; }
    }
}
