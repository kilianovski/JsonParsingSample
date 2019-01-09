using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
   public class MyModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] MyModel model)
        {
            return $"Welcome, {model.Name}! I know, that you are {model.Age} y.o.";
        }
    }
}
