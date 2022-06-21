using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class StudentCoursesController : Controller
    {
        public IActionResult StudentCourses()
        {
            return View();
        }
    }
}
