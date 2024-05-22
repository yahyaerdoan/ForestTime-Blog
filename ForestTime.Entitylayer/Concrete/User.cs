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
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;   
        public DateTime? CreatedDate { get; set; } = null;
        public DateTime? UpdatedDate { get; set; } = null;    
        public string Description { get; set; } = string.Empty;
        public bool? Status { get; set; } = null;
    }
}
