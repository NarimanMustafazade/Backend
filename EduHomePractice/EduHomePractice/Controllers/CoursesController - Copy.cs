using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
