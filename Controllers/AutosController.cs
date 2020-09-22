using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data;
using Autos.Data.interfaces;
using Autos.Data.Models;
using Autos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Autos.Controllers
{
    public class AutosController : Controller
    {
        private readonly IAllAutos _allAutos;

        public AutosController(IAllAutos iAllAutos)
        {
            _allAutos = iAllAutos;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            AutosListViewModel obj = new AutosListViewModel();
            obj.AllAutos = _allAutos.Autos;
            return View(obj);
        }

        public string GET()
        {
            JSonHelper jSonHelper = new JSonHelper();
            return jSonHelper.ConvertObjectToJSon(_allAutos.Autos);
        }

        public string GET_ID(int id)
        {
            JSonHelper jSonHelper = new JSonHelper();
            string result = jSonHelper.ConvertObjectToJSon(_allAutos.GetAuto(id));
            if (String.IsNullOrEmpty(result))
            {
                return "Объект не найден";
            }
            return jSonHelper.ConvertObjectToJSon(_allAutos.GetAuto(id));
        }
        //[HttpPost]
        public string Post([FromBody]Auto jsonauto)
        {
            JSonHelper jSonHelper = new JSonHelper();
            var model = jsonauto;//jSonHelper.ConvertJSonToObject<Auto>(jsonauto);
            //Auto tempauto = jSonHelper.ConvertJSonToObject<Auto>(inS);
            try
            {
               string s = _allAutos.AddAuto(jsonauto);
               return s;
            }
            catch (Exception e)
            {
                return "Failed to add";
            }
           
        }

        public string GETSTAT()
        {
            JSonHelper jSonHelper = new JSonHelper();
            return jSonHelper.ConvertObjectToJSon(_allAutos.Autos.Count());

        }
        [HttpDelete]
        public string Delete(int id)
        {
            
            return "Deleted";
        }

    }
}
