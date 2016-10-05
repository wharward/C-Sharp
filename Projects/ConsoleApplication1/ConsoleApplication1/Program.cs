using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool canVote = true;
            char grade = 'A';
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDec = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            var anotherName = "Tom";

            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());


        }
    }
}
