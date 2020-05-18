using System;
using System.Collections.Generic;
using System.Composition.Convention;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CerenetexUserManagement.Model.HttpModels;
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
            return Ok(userRepository.GetUser(int.Parse(id)));
        }

        [HttpPost]
        [Route("AddUser")]
        public ActionResult AddUser([FromBody]ResponseUser user)
        {
            User au = new User()
            {
                id = user.id,
                Age = user.Age,
                Dob = DateTime.Parse(user.Dob),
                Profileimage = user.Profileimage,
                Name = user.Name,
                Ethnicity = user.Ethnicity,
                Gender = user.Gender
            };

            using (var ms = new MemoryStream(Convert.FromBase64String("")))
            {

                //var img = Image.FromStream(ms);
                //return new Tuple<int, int>(img.Width, img.Height); // or some other data container
            }


            return Ok(userRepository.AddUser(au));
            //return Ok(null);
        }
        [HttpPost]
        [Route("UpdateUser")]
        public ActionResult UpdateUser([FromBody]ResponseUser user)
        {
            User au = new User()
            {
                id = user.id,
                Age = user.Age,
                Dob = DateTime.Parse(user.Dob),
                Profileimage = user.Profileimage,
                Name = user.Name,
                Ethnicity = user.Ethnicity,
                Gender = user.Gender
            };
            return Ok(userRepository.UpdateUser(au));
        }
    }
    public class GetResponseModel
    {
        public List<User> users { get; set; }
    }

}
