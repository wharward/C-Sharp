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
            List<int> numList = new List<int>();
            //Adding length to a list
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);
            //adding values to a list
            //Clear with numlist.Clear()

            //Add array to a list
            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            //Array into List
            List<int> numList2 = new List<int>(randArray);
            //List to Array
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            //Inserting and Removing
            numList.Insert(1, 10);
            numList.RemoveAt(2);
            //Cycle through a list
            for(int i=0; i< numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
            //Search location of data in a list
            Console.WriteLine("4 is in index: " + numList3.IndexOf(4));
            //Check if item is in a list
            Console.WriteLine("5 in List: " + numList.Contains(5));
            //Convert list to string
            List<string> strList = new List<string>(new string[] {"Tom", "Paul" });

            Console.WriteLine("Tom in list" + strList.Contains("tom",
                StringComparer.OrdinalIgnoreCase));

            strList.Sort();

        }
    }
}
