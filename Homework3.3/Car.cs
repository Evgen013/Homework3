using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._3
{
    class Car : Vehicle
    {
        public int numberPassengers;

        public void Show()
        {
            Console.WriteLine($"the number of passengers: {numberPassengers}");
        }
    }
}
