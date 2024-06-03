using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedHatController : ControllerBase
    {
        [HttpGet]
        [Route("redhat")]
        public IActionResult GetRedHat()
        {
            return Ok("Red hat is amazing:)");
        }
    }
}
