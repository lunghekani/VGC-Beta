using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class ViewProjectsController : Controller
    {
        public IActionResult ViewProjects()
        {
            return View();
        }
    }
}