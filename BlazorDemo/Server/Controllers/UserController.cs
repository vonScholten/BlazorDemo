using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<UserModel> Get()
        {
            return new List<UserModel>
            {
                new UserModel{FirstName = "Frederik", LastName = "von Scholten", Img="https://www.telegraph.co.uk/content/dam/Pets/spark/royal-canin/tabby-kitten-small-xlarge.jpg" },
                new UserModel { FirstName = "Iman", LastName = "Chelhi", Img="https://www.telegraph.co.uk/content/dam/Pets/spark/royal-canin/tabby-kitten-small-xlarge.jpg" },
                new UserModel{FirstName = "Sarina", LastName = "Bibæk", Img="https://www.telegraph.co.uk/content/dam/Pets/spark/royal-canin/tabby-kitten-small-xlarge.jpg" },
            };
        }

        [HttpPost]
        public void Post(UserModel user) { }
    }
}