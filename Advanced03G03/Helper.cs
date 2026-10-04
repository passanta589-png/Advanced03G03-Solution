using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced03G03
{
    internal class Helper
    {
        public static void PrintCollection<T> ( string CollectionName, IEnumerable<T> collection)
        {
            Console.WriteLine($"Collection: {CollectionName}");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
