using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        [Route("login")]
        [HttpPost]
        public Task<IActionResult> OnLogin()
        {
            throw new NotImplementedException();
        }

        [Route("logout")]
        [HttpPost]
        public Task<IActionResult> OnLogout()
        {
            throw new NotImplementedException();
        }
    }
}
