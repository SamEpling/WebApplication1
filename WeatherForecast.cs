using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Sam Epling" });
        }
    }
}