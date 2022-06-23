using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CoursesAvailable()
        {
            return View();
        }
        public IActionResult AddCourse()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult ViewUser()
        {
            return View();
        }
        public IActionResult ViewLecturers()
        {
            return View();
        }
    }
}

