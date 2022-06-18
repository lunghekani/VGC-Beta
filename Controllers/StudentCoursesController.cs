using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class StudentCoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
