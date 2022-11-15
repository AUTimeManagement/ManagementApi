using AUTimeManagement.Api.Management.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> OnGet()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> OnCreate([FromBody] ProjectViewModel model) { throw new NotImplementedException(); }

        [Route("{projectId:guid}")]
        [HttpGet]
        public Task<IActionResult> OnGet([FromRoute] Guid projectId)
        {
            throw new NotImplementedException();
        }

        [Route("{projectId:guid}")]
        [HttpPut]
        public Task<IActionResult> OnUpdate(
            [FromRoute] Guid projectId,
            [FromBody] ProjectViewModel model)
        {
            throw new NotImplementedException();
        }

        [Route("{projectId:guid}")]
        [HttpDelete]
        public Task<IActionResult> OnDelete([FromRoute] Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
