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
        new UserModel{Username = "Toothless", FirstName = "Frederik", LastName = "von Scholten", Img="https://d.wattpad.com/story_parts/497755278/images/15049796c1ac291360005534504.jpg" },
        new UserModel{Username = "Light Fury", FirstName = "Pernille Marie", LastName = "Lindschov Hansen", Img="https://vignette.wikia.nocookie.net/loveinterest/images/4/4e/Light_Fury_Headshot.jpg/revision/latest?cb=20181011175457" },
      };
    }

    [HttpPost]
    public void Post(UserModel user) { }
  }
}