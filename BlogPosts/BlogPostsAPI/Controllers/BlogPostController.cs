using BlogPostsAPI.Data.Models;
using BlogPostsAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {

        private readonly IBlogPostService _service;
        public BlogPostController(IBlogPostService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetBlogPosts()
        {

            var result = _service.GetBlogPosts();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddBlogPost([FromBody] BlogPost blogPost)
        {
            _service.AddBlogPost(blogPost);
            return StatusCode(201);
        }
        [HttpPut]
        public IActionResult UpdateBlogPost([FromBody] BlogPost blogPost)
        {

            _service.UpdateBlogPost(blogPost);
            return StatusCode(201);
        }
        [HttpDelete]
        public IActionResult DeleteBlogPost([FromBody] BlogPost blogPost, int i)
        {
            _service.DeleteBlogPost(blogPost, i);
            return StatusCode(201);
        }
    }   


}
