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
    //Random rdn = new Random();

    public List<UserModel> Data()
    {
      List<UserModel> __ = new List<UserModel>();

      __.Add(new UserModel
      {
        Id = 0,
        Username = "Toothless",
        FirstName = "Frederik",
        LastName = "von Scholten",
        Img = "https://d.wattpad.com/story_parts/497755278/images/15049796c1ac291360005534504.jpg",
        Email = "frederik@toothless.com"
      });
      __.Add(new UserModel
      {
        Id = 1,
        Username = "Light Fury",
        FirstName = "Pernille Marie",
        LastName = "Lindschov Hansen",
        Img = "https://vignette.wikia.nocookie.net/loveinterest/images/4/4e/Light_Fury_Headshot.jpg/revision/latest?cb=20181011175457",
        Email = "light@fury.com"
      });
      __.Add(new UserModel
      {
        Id = 2,
        Username = "Maverick",
        FirstName = "Mikkel",
        LastName = "Refsgaard Schmidt-Nielsen",
        Img = "https://media1.s-nbcnews.com/j/newscms/2017_21/1216637/top-gun-movie-today-170524-inline-4_b7f9b1ce3dec3d29b5e181ee7481b46a.fit-760w.jpg",
        Email = "mikkel@maverick.com"
      });
      __.Add(new UserModel
      {
        Id = 3,
        Username = "Marocco",
        FirstName = "Iman",
        LastName = "Chelhi",
        Img = "https://www.contrepoints.org/wp-content/uploads/2011/02/800px-Flag_of_Morocco_svg1.png",
        Email = "iman@chelhi.com"
      });


      string[] maleNames = new string[] { "Aaron", "Abdul", "Abe", "Abel", "Abraham", "Adam", "Adan", "Adolfo", "Adolph", "Adrian" };
      string[] femaleNames = new string[] { "Abby", "Abigail", "Adele", "Adrian" };
      string[] lastNames = new string[] { "Abbott", "Acosta", "Adams", "Adkins", "Aguilar" };

      for (int i = 0; i < 100; i++)
      {
        UserModel _ = new UserModel();

        Random rnd = new Random();

        _.Id = rnd.Next(111111, 999999);

        if (rnd.Next(1, 2) == 1)
        {
          _.FirstName = maleNames[rnd.Next(0, maleNames.Length - 1)];
        }
        else
        {
          _.FirstName = femaleNames[rnd.Next(0, femaleNames.Length - 1)];
        }

        _.LastName = lastNames[rnd.Next(0, lastNames.Length - 1)];

        _.Img = "https://scontent.xx.fbcdn.net/v/t51.2885-15/70461189_2371954689714242_6737601159839427505_n.jpg?_nc_cat=107&_nc_sid=8ae9d6&_nc_ohc=NuCjiLpAtz0AX-5zyMP&_nc_ht=scontent.xx&oh=4c4961cec61e9d5a1553139444179073&oe=5E7FFE35";

        _.Email = $"{_.FirstName}@{_.LastName}.com";

        _.Birthday = DateTime.Now;

        __.Add(_);
      }

      return __;
    }

    [HttpGet]
    [Route("all")]
    public List<UserModel> Get()
    {
      return Data();
    }

    [HttpPost]
    public void Post(UserModel user) { }
  }
}