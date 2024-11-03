using Microsoft.AspNetCore.Mvc;

namespace BasicOcelotApi.Controllers
{
    public class BasicOcelot
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
