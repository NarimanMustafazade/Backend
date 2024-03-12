using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
