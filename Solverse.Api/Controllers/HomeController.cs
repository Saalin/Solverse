using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Solverse.Api.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;

        public HomeController(IHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(hostEnvironment.EnvironmentName);
        }
    }
}
