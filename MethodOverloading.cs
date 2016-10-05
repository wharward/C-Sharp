using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Animal
    {
        //Method overloading is loading an object with more than once with different data types
        static public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        static public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            //attribute values can be declared in different order if specified by '(attr name):value'
            Console.WriteLine(getSum(num2: 2, num1: 2.7));
        }
    }
}
