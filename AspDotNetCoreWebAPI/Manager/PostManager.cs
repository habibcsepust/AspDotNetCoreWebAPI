using AspDotNetCoreWebAPI.Context;
using AspDotNetCoreWebAPI.Interfaces.Manager;
using AspDotNetCoreWebAPI.Models;
using AspDotNetCoreWebAPI.Repository;
using EF.Core.Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Manager
{
    public class PostManager:CommonManager<Post>,IPostManager
    {
        public PostManager(ApplicationDbContext dbContext) : base(new PostRepository(dbContext)) 
        { 

        }
    }
}
