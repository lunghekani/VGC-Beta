using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class MarksController : Controller
    {
        [Authorize]
        public IActionResult Marks()
        {
            return View();
        }
    }
}
