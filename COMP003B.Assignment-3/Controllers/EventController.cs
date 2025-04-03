using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment_3.Models;

namespace COMP003B.Assignment_3.Controllers
{
    // Handles request that start with "/event".
    [Route("event")]
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register(string eventCode = "spring-2025")
        {
            return View();
        }

        
    }
}
