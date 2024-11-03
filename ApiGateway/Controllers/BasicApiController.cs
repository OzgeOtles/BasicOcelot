using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    public class BasicApiController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ValuesController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(new { Message = "Hello from ApiService!" });
            }
        }
    }
}
