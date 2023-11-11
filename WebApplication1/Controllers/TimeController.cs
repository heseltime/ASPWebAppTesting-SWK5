using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("time2/")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public object GetTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
