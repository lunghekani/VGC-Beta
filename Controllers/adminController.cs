﻿using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CoursesAvailable()
        {
            return View();
        }
        public IActionResult AddCourse()
        {
            return View();
        }
    }
}

