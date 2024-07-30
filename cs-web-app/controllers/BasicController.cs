using cs_web_app.models;
using Microsoft.AspNetCore.Mvc;

namespace cs_web_app.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController
    {
        // ?search=1&search=2
        [HttpGet]
        public void GetAll([FromQuery] SomeModel someModel)
        {
            Console.WriteLine(someModel);
        }
    }
}

