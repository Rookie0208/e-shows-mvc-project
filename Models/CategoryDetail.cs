using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class CategoryDetail
    {
        public int CtId { get; set; }
        public string? CtName { get; set; }
        public int? CmId { get; set; }
        public DateTime? CtCdt { get; set; }
        public DateTime? CtMdt { get; set; }
        public bool? CtIsActive { get; set; }

        public virtual CategoryMaster? Cm { get; set; }
    }
}
