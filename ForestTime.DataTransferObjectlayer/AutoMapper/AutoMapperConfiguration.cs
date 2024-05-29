using AutoMapper;
using ForestTime.DataTransferObjectLayer.BlogDtos;
using ForestTime.DataTransferObjectLayer.RoleDtos;
using ForestTime.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity;
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
			CreateMap<Blog, CreateBlogDto>().ReverseMap();			
            CreateMap<CreateRoleDto, Role>().ReverseMap();
            CreateMap<UpdateRoleDto, Role>().ReverseMap();
        }
	}
}
