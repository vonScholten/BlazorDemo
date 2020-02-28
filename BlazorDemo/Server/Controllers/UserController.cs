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
        new UserModel{Username = "Toothless", FirstName = "Frederik", LastName = "von Scholten", Img="https://d.wattpad.com/story_parts/497755278/images/15049796c1ac291360005534504.jpg", Email="example@example.com" },
        new UserModel{Username = "Light Fury", FirstName = "Pernille Marie", LastName = "Lindschov Hansen", Img="https://vignette.wikia.nocookie.net/loveinterest/images/4/4e/Light_Fury_Headshot.jpg/revision/latest?cb=20181011175457", Email="example@example.com" },
        new UserModel{Username = "Maverick", FirstName = "Mikkel", LastName = "Refsgaard Schmidt-Nielsen", Img="https://media1.s-nbcnews.com/j/newscms/2017_21/1216637/top-gun-movie-today-170524-inline-4_b7f9b1ce3dec3d29b5e181ee7481b46a.fit-760w.jpg", Email="example@example.com" },
        new UserModel{Username = "Marocco", FirstName = "Iman", LastName = "Chelhi", Img="https://www.contrepoints.org/wp-content/uploads/2011/02/800px-Flag_of_Morocco_svg1.png", Email="example@example.com" },
      };
    }

    [HttpPost]
    public void Post(UserModel user) { }
  }
}