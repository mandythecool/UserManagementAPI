using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Model;
using SampleWebApi.Model.Entities;

namespace SampleWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserController : Controller
    {
        public readonly IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        [HttpGet]
        [Route("GetUsers")]
        public ActionResult GetUsers()
        {
            return Ok(new GetResponseModel() { users = userRepository.GetUsers().ToList() }); ;
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult GetUser(string id)
        {
            return Ok(userRepository.GetUser(Guid.Parse(id)));
        }
        [HttpPost]
        [Route("AddUser")]
        public ActionResult AddUser([FromBody]User user)
        {
            return Ok(userRepository.AddUser(user));
            //return Ok(null);
        }
        [HttpPost]
        [Route("UpdateUser")]
        public ActionResult UpdateUser([FromBody]User user)
        {
            return Ok(userRepository.UpdateUser(user));
        }
    }
    public class GetResponseModel
    {
        public List<User> users { get; set; }
    }

}
