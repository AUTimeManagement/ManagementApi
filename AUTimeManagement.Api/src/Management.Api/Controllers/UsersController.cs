using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult OnGet()
        {
            return Ok();
        }

        [Route("{userId:guid}")]
        [HttpGet]
        public IActionResult OnGet([FromRoute] Guid userId)
        {
            return Ok();
        }

        [Route("{userId:guid}")]
        [HttpPut]
        public IActionResult OnUpdate([FromRoute] Guid userId)
        {
            return Ok();
        }

        [Route("{userId:guid}")]
        [HttpDelete]
        public IActionResult OnDelete([FromRoute] Guid userId)
        {
            return Ok();
        }

        [Route("/api/me")]
        [HttpGet]
        public Task<IActionResult> OnMe()
        {
            throw new NotImplementedException();
        }
    }
}
