using BlogPostsAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Services
{
    public interface IBlogPostService


    {
        List<BlogPost> GetBlogPosts();

        void AddBlogPost(BlogPost blogPost);

        void UpdateBlogPost(BlogPost blogPost);

        void DeleteBlogPost(BlogPost blogPost, int i);
    }
}
