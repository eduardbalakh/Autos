using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data.interfaces;
using Autos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Autos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllAutos _autoRep;

        public HomeController(IAllAutos autoRep)
        {
            _autoRep = autoRep;
        }

        public ViewResult Index()
        {
            HomeViewModel obj = new HomeViewModel();
            obj.allAutos = _autoRep.Autos;
            return View(obj);
        }

    }
}
