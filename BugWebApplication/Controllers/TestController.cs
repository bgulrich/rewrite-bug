using Microsoft.AspNetCore.Mvc;

namespace BugWebApplication.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("/test/favicon.ico")]
        public IActionResult Index()
        {
            return Ok("You shouldn't see me.");
        }
    }
}
