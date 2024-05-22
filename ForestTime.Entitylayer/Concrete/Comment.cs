using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.Entitylayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime? CommentDate { get; set; } = null;
        public bool? Status { get; set; } = false;
    }
}
