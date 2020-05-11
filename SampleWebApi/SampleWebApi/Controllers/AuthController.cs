using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]

    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string Login([FromBody]RequestModel model ) {
            if (model.username.Equals("test") && model.password.Equals("test"))
                return "true";
            else
                return "false";
        }
    }

    public class RequestModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}