using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class TimetableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
