using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox_Snippet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is here is show you can added your favorite code from the Toolbox!");

            Console.WriteLine("Just go to the toolbox and double-click to instert the code!");

            Console.WriteLine("Did you do it? (Yes/No)");

            string name = Console.ReadLine();

            if (name == "Yes")
            {
                Console.WriteLine("Good job!");     
            }
            if (name == "No")
            {
                Console.WriteLine("Just keep trying!");
            }
            //Wait for the user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
