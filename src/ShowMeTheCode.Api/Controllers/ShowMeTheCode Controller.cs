using Microsoft.AspNetCore.Mvc;

namespace ShowMeTheCode.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string url = "https://github.com/josercarvalho/Softplan";

            return Ok(value: url);
        }
    }
}
