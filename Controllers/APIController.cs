using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Autos.Data;
using Autos.Data.interfaces;
using Autos.Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Autos.Controllers //API controller
{
    [Route("/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly IAllAutos _allAutos;   //objects repository

        public APIController(IAllAutos iAllAutos)
        {
            this._allAutos = iAllAutos;
        }
        // GET: api/<APIController>
        [HttpGet]
        public string Get()     //GET method
        {
            JSonHelper jSonHelper = new JSonHelper();
            return jSonHelper.ConvertObjectToJSon(_allAutos.Autos);
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public string Get(int id)   //GET/id method
        {
            JSonHelper jSonHelper = new JSonHelper();
            if (_allAutos.Autos.Where(c => c.Id == id).Count() == 0) return "Объект не найден";
            string result = jSonHelper.ConvertObjectToJSon(_allAutos.GetAuto(id));
            return jSonHelper.ConvertObjectToJSon(_allAutos.GetAuto(id));
        }

        // POST api/<APIController>
        [HttpPost]
        public string Post([FromBody] Auto jsonauto)    //POST method
        {
            var model = jsonauto;
            try
            {
                return _allAutos.AddAuto(jsonauto);
            }
            catch (Exception e)
            {
                return "Failed to add - Exception";
            }
        }
        
        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)    //Delete method
        {
            try
            {
                return _allAutos.DeleteAuto(id);
            }
            catch (Exception e)
            {
                return "Failed to delete - Exception";
            }
        }
        [HttpGet("stat")]
        public string GetStat()     //GetStat method
        {

            JSonHelper jSonHelper = new JSonHelper();
            return jSonHelper.ConvertObjectToJSon(_allAutos.Autos.Count());
        }
    }
}
