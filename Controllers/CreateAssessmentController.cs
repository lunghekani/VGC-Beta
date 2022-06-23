using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class CreateAssessmentController : Controller
    {
        public IActionResult CreateAssessment()
        {
            return View();
        }

        public IActionResult StudentAssessment()
        {
            return View();
        }
    }
}