using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    //An enumerated type 'enum' is a type has sybolic names and associated values
    public enum Temperature
    {
        //Settings
        Freeze,
        Low,
        Warm,
        Boil
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Temp = Console.ReadLine("Set temp setting: Freeze, Low, Warm, Boil");


            Temperature micTemp = Temperature.Warm;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
                

        }
    }
}
