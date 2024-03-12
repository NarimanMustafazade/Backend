using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
