using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autos.Data.Models;

namespace Autos.ViewModels
{
    public class AutosListViewModel
    {
        public IEnumerable<Auto> AllAutos { get; set; }
    }
}
