using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("time2/")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public object GetTime()
        {
            return new { Time = DateTime.Now.ToString("o") };
        }
    }
}
