using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class TimetableController : Controller
    {
        [Authorize]
        public IActionResult Timetable()
        {
            return View();
        }
    }
}
