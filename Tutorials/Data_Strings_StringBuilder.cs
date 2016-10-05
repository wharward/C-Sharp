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
            //DEclaring the arracy variable
            int[] randNumArray;
            //Declaring Arracy length
            int[] randArray = new int[5];
            //Add values to array
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Lrngth:" + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, randArray2[i]);
            }

            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));

            //String Arrays
            string[] names = {"Tom", "Dick", "Harry" };

            string nameStr = string.Join(", ", names);
            Console.WriteLine(nameStr);

            string[] nameArray = nameStr.Split(',');

            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine("{1}", i, nameArray[i]);
            }

            //Multi-Demensional

            int[,]multArray = new int[5, 3];

            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for(int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} :{2}", x, y, multArray2[x, y]);
                }
                
            }

        }
    }
}
