using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Data.Models
{
    public class BlogPost
    {
        public string slug { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public string body { get; set; }

        public string tagList { get; set; } 

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }


        public BlogPost()
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }

    }
}
