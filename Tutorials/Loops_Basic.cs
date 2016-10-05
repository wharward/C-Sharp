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

            string guess;

            Console.WriteLine("Do Loops:");
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();

            } while (!guess.Equals("15"));

            Console.WriteLine("For Loops:");
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("While Loops:");
            string randStr = "Here are some random characters";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
