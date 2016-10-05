using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegate is used to pass methods as arguments to other methods
//similiar 
delegate double GetSum(double num1, double num2);

namespace ConsoleApplication8
{
    class Program
    {

        //an anonymous method has no name, and return type is defined by the return that is used in the method
        static void Main(string[] args)
        {

            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));
            
        }
    }
}
