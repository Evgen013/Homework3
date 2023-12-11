using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._5
{
    internal class Printer
    {
        public ConsoleColor color;

        public Printer(ConsoleColor color) 
        {
            this.color = color;
        }

        public virtual void Print(string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
    }
}
