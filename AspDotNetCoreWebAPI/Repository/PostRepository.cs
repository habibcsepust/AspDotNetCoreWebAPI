using AspDotNetCoreWebAPI.Context;
using AspDotNetCoreWebAPI.Interfaces.Repository;
using AspDotNetCoreWebAPI.Models;
using EF.Core.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Repository
{
    public class PostRepository: CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext) { 

        }
    }
}
