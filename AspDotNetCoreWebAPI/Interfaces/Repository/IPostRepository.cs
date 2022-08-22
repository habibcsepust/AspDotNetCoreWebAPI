using AspDotNetCoreWebAPI.Models;
using EF.Core.Repository.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Interfaces.Repository
{
    interface IPostRepository: ICommonRepository<Post>
    {
    }
}
