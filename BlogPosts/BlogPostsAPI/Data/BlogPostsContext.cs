using BlogPostsAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Data
{
    public class BlogPostsContext : DbContext

    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public BlogPostsContext(DbContextOptions<BlogPostsContext> options): base(options)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BlogPost>().HasKey(b=>b.slug);

            modelBuilder.Entity<BlogPost>().Property(b => b.title).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
