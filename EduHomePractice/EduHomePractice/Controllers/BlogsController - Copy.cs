using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
