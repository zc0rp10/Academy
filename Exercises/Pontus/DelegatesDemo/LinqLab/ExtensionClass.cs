using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
 
namespace LinqLab
{
    static public class ExtensionClass
    {
        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        //public static void Print<T>(this IEnumerable<T> collection, Func<T, object> predicate)
        //{
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine(predicate(item));
        //    }
        //}

        public static void Print<T>(this IEnumerable<T> collection, Func<T, string> Greyhound)
        {
            foreach (var item in collection)
            {
                string result = Greyhound(item);
                Console.WriteLine(result);
            }
        }

        public static void Print<T>(this IEnumerable<T> collection, Func<T, int> predicate)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(predicate(item));
            }
        }

        public static void Print<T>(this IEnumerable<T> collection, Func<T, double> predicate)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(predicate(item));
            }
        }

        public static void Print<T>(this IEnumerable<T> collection, Func<T, float> predicate)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(predicate(item));
            }
        }
    }
}
