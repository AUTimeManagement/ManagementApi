using AUTimeManagement.Api.Management.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkHoursController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> OnCreate(
            [FromQuery] Guid userId,
            [FromQuery] Guid projectId,
            [FromBody] WorkUnitViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
