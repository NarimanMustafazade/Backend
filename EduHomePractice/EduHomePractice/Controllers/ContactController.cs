using Microsoft.AspNetCore.Mvc;

namespace EduHomePractice.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
