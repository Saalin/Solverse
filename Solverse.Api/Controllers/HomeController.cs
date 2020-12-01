using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Solverse.Application.Commands;
using Solverse.Application.Queries;
using System.Threading.Tasks;

namespace Solverse.Api.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly IHostEnvironment hostEnvironment;
        private readonly IMediator mediator;

        public HomeController(IHostEnvironment hostEnvironment, IMediator mediator)
        {
            this.hostEnvironment = hostEnvironment;
            this.mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(hostEnvironment.EnvironmentName);
        }

        [HttpGet("examples")]
        public async Task<IActionResult> GetExamples()
        {
            var result = await mediator.Send(new ExamplesListQuery());
            return Ok(result);
        }

        [HttpPost("examples")]
        public async Task<IActionResult> CreateExample(CreateExampleCommand createExampleCommand)
        {
            await mediator.Send(createExampleCommand);
            return Ok();
        }
    }
}
