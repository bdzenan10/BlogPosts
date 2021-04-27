using BlogPostsAPI.Data;
using BlogPostsAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Repos
{
    public class BlogPostRepo : IBlogPostRepo
    {
        private readonly BlogPostsContext _context;
        public BlogPostRepo(BlogPostsContext context)
        {
            _context = context;
        }
        List<BlogPost> result = new List<BlogPost>();
        //Returns list of BlogPosts
        public void AddBlogPost(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            _context.SaveChanges();
        }

        public List<BlogPost> GetBlogPosts()
        {

            
            return _context.BlogPosts.Where(b=>b.IsDeleted==false).ToList();
        }
        public void UpdateBlogPost(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            _context.SaveChanges();
        }
        public void DeleteBlogPost(BlogPost blogPost, int i)
        {
            _context.BlogPosts.Remove(blogPost);
        }
    }
}
