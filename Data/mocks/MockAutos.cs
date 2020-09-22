//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Autos.Data.interfaces;
//using Autos.Data.Models;

//namespace Autos.Data.mocks
//{
//    public class MockAutos :IAllAutos
//    {
//        private readonly IAutoCategory _autoCategory = new MockCategory();
//        public IEnumerable<Auto> Autos
//        {
//            get
//            {
//                return new List<Auto>
//                {
//                    new Auto
//                    {
//                        Name = "Skoda Octavia",
//                        AutoColour = "Black",
//                        Desc = "1.4 TSI",
//                        Image = "/img/Skoda.jpg",
//                        Number = "K233EY196",
//                        Year = 2018
//                    },
//                    new Auto
//                    {
//                        Name = "Chevrolet Captiva",
//                        AutoColour = "Black",
//                        Desc = "2.4 atmo",
//                        Image = "/img/Captiva.jpg",
//                        Number = "A123BC72",
//                        Year = 2008,
//                    },
//                    new Auto
//                    {
//                        Name = "Tesla Model S",
//                        AutoColour = "Silver",
//                        Desc = "Electric one",
//                        Image = "/img/Tesla.jpg",
//                        Number = "A777CB777",
//                        Year = 2020,
//                    },
//                    new Auto
//                    {
//                        Name = "BMW X5",
//                        AutoColour = "Gray",
//                        Desc = "Big one",
//                        Image = "/img/BMW.jpg",
//                        Number = "A001MO77",
//                        Year = 2019,
//                    },
//                    new Auto
//                    {
//                        Name = "Honda Pilot",
//                        AutoColour = "White",
//                        Desc = "Where is all fuel?",
//                        Image = "/img/Honda.jpg",
//                        Number = "H345TT196",
//                        Year = 2020

//                    }
//                };
//            }
//        }
//        public IEnumerable<Auto> GetFavAutos { get; set; }
//        public Auto GetAuto(int autoId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
