using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._3
{
    class Vehicle
    {
        public string coordinates;
        public int price;
        public double speed;
        public int releaseDate;

        public void Show()
        {
            Console.WriteLine($"coordinates: {coordinates}");
            Console.WriteLine($"price: {price}");
            Console.WriteLine($"speed: {speed}");
            Console.WriteLine($"date of release: {releaseDate}");
        }
    }  
}
//зроблено
