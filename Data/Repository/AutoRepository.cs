using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data.interfaces;
using Autos.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Autos.Data.Repository
{
    public class AutoRepository : IAllAutos     //Хранилище авто
    {
        private readonly AppDBContent appDBContent;

        public AutoRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Auto> Autos => appDBContent.Auto.Include(c => c);    //Get all objects
        public Auto GetAuto(int autoId) => appDBContent.Auto.FirstOrDefault(p => p.Id == autoId); //Search by ID

        public string AddAuto(Auto element)     //Add object to DB
        {
            if (Autos.Select(s => s.Number == element.Number).Select(c => c == true).Contains(true))    //Validate if the object has already been added
                return "Объект уже существует";
            appDBContent.Add(element);
            appDBContent.SaveChanges();
            return "Автомобиль добавлен";
        }

        public string DeleteAuto(int id)    //Delete objects by ID
        {
            var temp = Autos.FirstOrDefault(p=>p.Id==id);   //Validate if there is an object with the ID
            if (temp == null)
            {
                return "Объект не найден";
            }
            appDBContent.Remove(temp);
            appDBContent.SaveChanges();
            return "Удалено успешно";
        }

    }
}
