using AUTimeManagement.Api.Management.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {

        [HttpPost]
        public Task<IActionResult> OnCreate(
            [FromBody] DepartmentCreateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
