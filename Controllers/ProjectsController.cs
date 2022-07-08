using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class ProjectsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult createProject()
        {
            return View();
        }
        public IActionResult editProject()
        {
            return View();
        }
        public IActionResult deleteProject()
        {
            return View();
        }
        public IActionResult listProject()
        {
            return View();
        }
    }
}
