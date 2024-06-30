using System;
using System.Collections.Generic;

namespace e_shows.Models
{
    public partial class CategoryMaster
    {
        public CategoryMaster()
        {
            CategoryDetails = new HashSet<CategoryDetail>();
        }

        public int CmId { get; set; }
        public string? CmName { get; set; }

        public virtual ICollection<CategoryDetail> CategoryDetails { get; set; }
    }
}
