using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.DataTransferObjectLayer.BlogDtos
{
	public class CreateBlogDto
	{
		public string Title { get; set; }
		public string Header { get; set; }
		public string CoverImageUrl { get; set; }
		public string ThumbnailImageUrl { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public int ViewingCount { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public int CategoryId { get; set; }
		public int UserId { get; set; }
	}
}
