using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1 = 10.5;
            double number2 = 15;

            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (rand.Next(1, 11)));

        }
    }
}
