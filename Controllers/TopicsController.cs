using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VGC.Controllers
{
    public class TopicsController : Controller
    {
        //[Authorize]
        public IActionResult Topics()
        {
            return View();
        }
        //public IActionResult List()
        //{
        //    return View();
        //}
    }
}