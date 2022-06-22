using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
