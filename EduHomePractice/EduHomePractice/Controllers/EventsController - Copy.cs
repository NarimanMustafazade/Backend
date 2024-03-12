using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
