﻿using ForestTime.BusinessLayer.Abstract.IAbstracService;
using ForestTime.DataAccessLayer.Abstract.IAbstactDal;
using ForestTime.Entitylayer.Concrete;
using System.Linq.Expressions;

namespace ForestTime.BusinessLayer.Concrete.ConcreteManager
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);          
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Blog Get(Expression<Func<Blog, bool>> filter)
        {
            var values = _blogDal.Get(filter);
            return values;
        }

        public List<Blog> GetAll(Expression<Func<Blog, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Blog?> GetBlogDetailById(int id)
        {
            var values = await _blogDal.GetBlogDetailById(id);
            return values;
        }

        public async Task<List<Blog>> GetBlogsByUserIdAsync(int id)
        {
            var values = await _blogDal.GetBlogsByUserIdAsync(id);
            return values;
        }

        public async Task<List<Blog>> GetBlogsWithCategoryAndUserAsync()
        {
            var values = await _blogDal.GetBlogsWithCategoryAndUserAsync();
            return values;
        }

        public async Task<List<Blog>> GetLastTwoBlogByUserIdAsync(int id)
        {
            var values = await _blogDal.GetLastTwoBlogByUserIdAsync(id);
            return values;
        }

        public void IncreaseBlogViewingCount(int id)
        {
            _blogDal.IncreaseBlogViewingCount(id);
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
