using Microsoft.AspNetCore.Mvc;

namespace AUTimeManagement.Api.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        /// <summary>
        /// Endpoint GET /api/report/
        /// </summary>
        /// <returns><see cref="IActionResult"/></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public Task<IActionResult> OnGet()
        {
            throw new NotImplementedException();
        }
    }
}
