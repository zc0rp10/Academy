using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    static class ExtensionClass
    {
        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(this IEnumerable<T> collection, Func<T, object> predicate)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(predicate(item));
            }
        }
    }
}
