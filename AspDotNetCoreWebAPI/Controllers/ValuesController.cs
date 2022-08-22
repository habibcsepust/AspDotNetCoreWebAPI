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
    public class ValuesController : ControllerBase
    {
        //[Route("GetFisrtName")]
        //[Route("[action]")]
        [HttpGet]
        public string GetName() {
            return "Habib";
        }
        //[Route("GetFullName")]
        //[Route("[action]")]
        [HttpGet]
        public string GetFullName()
        {
            return "Md. Habibur Rahman";
        }
    }
}
