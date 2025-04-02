using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment_3.Models;

namespace COMP003B.Assignment_3.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
