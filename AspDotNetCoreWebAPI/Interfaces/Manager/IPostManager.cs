using AspDotNetCoreWebAPI.Models;
using EF.Core.Repository.Interface.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Interfaces.Manager
{
    interface IPostManager: ICommonManager<Post>
    {
    }
}
