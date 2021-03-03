using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        public Cars(string brand, string model, string color, string type, int year)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Type = type;
            Year = year;
        }
    }
}