using AspDotNetCoreWebAPI.Context;
using AspDotNetCoreWebAPI.Interfaces.Manager;
using AspDotNetCoreWebAPI.Manager;
using AspDotNetCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        PostManager _postManager;
        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _postManager = new PostManager(dbContext);
        }

        //IPostManager _postManager;
        //public PostController(IPostManager postManager)
        //{
        //    _postManager = postManager;
        //}

        [HttpGet]
        public List<Post> GetAll() {
            //var posts = _dbContext.Posts.ToList();
            var posts = _postManager.GetAll().ToList();
            return posts;
        }

        [HttpPost]
        public Post Add(Post post) {
            post.CreatedDate = DateTime.Now;
            //_dbContext.Posts.Add(post);
            //bool isSaved = _dbContext.SaveChanges() > 0;
            bool isSaved = _postManager.Add(post);
            if (isSaved)
            {
                return post;
            }
            return null;
        }
    }
}
