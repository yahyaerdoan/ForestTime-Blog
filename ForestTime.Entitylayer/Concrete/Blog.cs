using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.Entitylayer.Concrete
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Header { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public string ThumbnailImageUrl { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; } = null;
        public DateTime? UpdatedDate { get; set; } = null;
        public int? ViewingCount { get; set; } = null;
        public string Description { get; set; } = string.Empty;
        public bool? Status { get; set; } = null;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
