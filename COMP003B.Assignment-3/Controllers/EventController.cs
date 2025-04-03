using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment_3.Models;
using System.Reflection.Metadata.Ecma335;

namespace COMP003B.Assignment_3.Controllers
{
    // Handles request that start with "/event".
    [Route("event")]
    public class EventController : Controller
    {
        [HttpGet("Event/Register/{eventCode}")]
        public IActionResult Register(string eventCode = "spring-2025")
        {
            return View();
        }

        [HttpGet("/Event/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/Event/Register")]
        public IActionResult Register([FromForm] EventRegistration Event) 
        {
            if (!ModelState.IsValid)
            {
                return View(Event);
            }

            return RedirectToAction("Success", Event);
        }

        [Route("success")]
        public IActionResult Success(EventRegistration Event)
        {
            return View(Event);
        }
    }
}
