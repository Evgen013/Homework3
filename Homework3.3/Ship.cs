using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._3
{
    class Ship : Vehicle
    {
        public string homePort;

        public void Show()
        {
            Console.WriteLine($"home port: {homePort}");
        }
    }
}
