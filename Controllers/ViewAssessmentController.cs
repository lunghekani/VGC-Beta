using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class ViewAssessmentController : Controller
    {
        public IActionResult ViewAssessment()
        {
            return View();
        }
    }
}