using Microsoft.AspNetCore.Mvc;

namespace HelloMicroservices.Controllers
{
    public class CurrentDateTimeController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult<String> GetCurrenteTimeStamp()
        {
            return Ok(DateTime.UtcNow);
        }
    }
}
