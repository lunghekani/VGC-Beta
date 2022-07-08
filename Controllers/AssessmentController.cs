using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace VGC.Controllers
{
    [Authorize]
    public class AssessmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateAssessment()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult StudentAssessment()
        {
            return View();
        }
        public IActionResult ViewAssessment()
        {
            return View();
        }

    }
}
