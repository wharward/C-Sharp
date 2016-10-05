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

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("Hello. My name is {0} and I live in {1}", "Aaron", "Washington");

            sb.Replace("r", "w");
            sb.Replace("l", "w");

            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());
            
        }
    }
}
