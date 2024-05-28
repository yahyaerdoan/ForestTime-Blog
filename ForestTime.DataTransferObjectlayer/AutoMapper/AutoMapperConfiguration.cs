using AutoMapper;
using ForestTime.DataTransferObjectLayer.BlogDtos;
using ForestTime.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestTime.DataTransferObjectLayer.AutoMapper
{
	public class  AutoMapperConfiguration : Profile
	{
		public AutoMapperConfiguration() 
		{
			CreateMap<Blog, CreateBlogDto>();
			CreateMap<CreateBlogDto, Blog>();
		}
	}
}
