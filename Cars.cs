using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CarDealerShow
{
    class Cars
    {
        public int ID { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public string ImagePath { get; set; }
   

        public Cars(int id, string registrationNumber, string make, string model, int year, int price, string imagePath)
        {
            this.ID = id;
            this.RegistrationNumber = registrationNumber;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.ImagePath = imagePath;
        }
        public override string ToString()
        {
            return $"[{ID}] {RegistrationNumber}; {Make}, {Model}, {Year},{Price}, {ImagePath}";
        }
    }
   
}
