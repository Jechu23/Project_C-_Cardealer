using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShow
{
    class InventoryCars
    {
        private List<Cars> cars = new List<Cars>(); 
        public InventoryCars()
        {
            cars.Add(new Cars(1, "X01", "Golf 1", "GT1", 1980, 5000, "images/"));
            cars.Add(new Cars(2, "X02", "Golf 2", "GT1x", 1985, 6000, "images/"));
            cars.Add(new Cars(3, "X03", "Golf 3", "GT1d", 1989, 7000, "images/"));
            cars.Add(new Cars(4, "X04", "Golf 4", "GT1z", 1990, 8000, "images/"));
            cars.Add(new Cars(5, "X05", "Golf 5", "GT1g", 1995, 9000, "images/"));
        }

        public List<Cars> GetCars()
        {
            return cars;
        }

    }
}
