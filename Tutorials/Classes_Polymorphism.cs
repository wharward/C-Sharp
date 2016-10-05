using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    //Generics do not require stating the data type
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue (TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}"+ this.key, this.value);
        }

        static void Main(string[] args)
        {
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "A Samsung TV";

            samsungTV.showData();
        }

    }
}
    