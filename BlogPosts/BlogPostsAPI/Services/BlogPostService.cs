using BlogPostsAPI.Data.Models;
using BlogPostsAPI.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepo _repo;
        public BlogPostService(IBlogPostRepo repo)
        {
            _repo = repo;
        }
        public void AddBlogPost(BlogPost blogPost)
        {

            _repo.AddBlogPost(blogPost);
        }

        public List<BlogPost> GetBlogPosts()
        {
            return _repo.GetBlogPosts();
        }

        public void UpdateBlogPost (BlogPost blogPost)
        {
            _repo.UpdateBlogPost(blogPost);
        }
        public void DeleteBlogPost(BlogPost blogPost, int i)
        {
            _repo.DeleteBlogPost(blogPost, i);        
        }
    }
}
