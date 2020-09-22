using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autos.Controllers
{
    public class AddAutoController : Controller
    {
        public IActionResult AddAuto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAuto(Auto auto)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
