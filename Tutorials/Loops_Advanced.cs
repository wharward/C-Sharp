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

            /* 
            \' single quote
            \" double quotes
            \\ backslash
            \b backspace
            \t tab
            */

            string sampleString = "A bunch of random words";
            string sampleString2 = "More random words";
            //Testing
            Console.WriteLine("Is empty" + String.IsNullOrEmpty(sampleString));
            Console.WriteLine("Is empty" + String.IsNullOrWhiteSpace(sampleString));
            Console.WriteLine("String Length " + sampleString.Length);
            //Searching
            Console.WriteLine("Index of \'bunch\': " + sampleString.IndexOf("bunch"));
            Console.WriteLine("2nd Word = \'" + sampleString.Substring(2, 6) + "\'");
            //Comparing
            Console.WriteLine("Strings Equal?" + sampleString.Equals(sampleString2));
            Console.WriteLine("Starts with \"A bunch\"" + sampleString.StartsWith("A bunch"));
            Console.WriteLine("Ends with \"A bunch\"" + sampleString.StartsWith("words"));
            //Editing 
            sampleString = sampleString.Trim(); //TrimEnd or TrimStart
            sampleString = sampleString.Replace("words", "characters");
            sampleString = sampleString.Remove(0, 2);
            //Concatenating arrays
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List: " + String.Join(", ", names));
            //Formatting
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(fmtStr);




        }
    }
}
