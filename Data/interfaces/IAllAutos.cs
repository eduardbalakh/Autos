using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data.Models;

namespace Autos.Data.interfaces
{
    public interface IAllAutos
    {
        IEnumerable<Auto> Autos { get;}
        Auto GetAuto(int autoId);
        string AddAuto(Auto element);
        string DeleteAuto(int id);
    }
}
