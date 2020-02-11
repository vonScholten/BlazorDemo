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
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> Get()
        {
            return new List<PersonModel>
            {
                new PersonModel{FirstName = "Frederik", LastName = "von Scholten", AccountBalance = 0.0M },
                new PersonModel { FirstName = "Frederik I", LastName = "von Scholten", AccountBalance = 0.1M },
                new PersonModel{FirstName = "Frederik II", LastName = "von Scholten", AccountBalance = 0.2M },
                new PersonModel{FirstName = "Frederik III", LastName = "von Scholten", AccountBalance = 0.3M }
            };   
        }

        [HttpPost]
        public void Post(PersonModel person) { }
    }
}