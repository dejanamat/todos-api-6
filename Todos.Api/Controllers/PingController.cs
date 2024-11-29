using Microsoft.AspNetCore.Mvc;

namespace Todos.Api.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        // GET: api/ping
        [HttpGet]
        public IActionResult Get()
        {
            var myName = System.Environment.GetEnvironmentVariable("MY_NAME") ?? "Jane Doe";
            return Ok("pong " + myName+" !! ");
        }
    }
}