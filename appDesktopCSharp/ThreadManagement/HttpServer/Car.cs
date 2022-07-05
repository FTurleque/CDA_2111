using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public static List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car() { Brand = "Ford", Model = "KA", Color = "Rouge" },
                new Car() { Brand = "Porshe", Model = "Taican", Color = "Noir" },
                new Car() { Brand = "Fiat", Model = "", Color = "Jaune"}
            };
        }
    }
}
