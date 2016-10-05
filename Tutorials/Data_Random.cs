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

            // RElational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementry school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't be working");
            }

            Console.WriteLine("! true " + (!true));

            bool canDrive = age >= 16 ? true : false;

            if (canDrive)
            {
                Console.WriteLine("You can drive!");
            } else
            {
                Console.WriteLine("You cannot drive!");
            }

            switch(age)
            {    
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;

            }

        Cute:
            Console.WriteLine("Toddlers are Cute");
        }
            
        }
    }
