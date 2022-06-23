using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class MarksController : Controller
    {
        public IActionResult Marks()
        {
            return View();
        }
    }
}
