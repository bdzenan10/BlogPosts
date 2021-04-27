using BlogPostsAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Repos
{
    public interface IBlogPostRepo
    {
        List<BlogPost> GetBlogPosts();

        void AddBlogPost(BlogPost blogPost);


        void UpdateBlogPost(BlogPost blogPost);

        void DeleteBlogPost(BlogPost blogpost, int i);
    }
}
