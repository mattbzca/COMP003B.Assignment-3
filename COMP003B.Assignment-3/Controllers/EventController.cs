using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment_3.Models;
using System.Reflection.Metadata.Ecma335;

namespace COMP003B.Assignment_3.Controllers
{
    
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register([FromRoute] string eventCode)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
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
