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

        static void Main(string[] args)
        {
            //Lambda used to act as an anonymous funtion or an expression tree
            //You can assign a lambda expression to a function instance

            //Assign the value to getSum = Attributes = statements
            Func<int, int, int> getSum = (x, y) => x + y;

            //Write expression
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            //Using a lamda with a list
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach(int num in oddNums)
            {
                Console.WriteLine(num + ", ");
            }
            
        }
    }
}
