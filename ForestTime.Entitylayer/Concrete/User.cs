using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.Entitylayer.Concrete
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; } = null;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; } 
        public string? Description { get; set; } = null;
        public bool Status { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
