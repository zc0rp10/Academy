using System;

namespace Delegater03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsLessThan(1, 2));

            Func<int,int,bool> f = IsLessThan;
            Console.WriteLine(f(1, 2));
            
        }

        static bool IsLessThan(int a, int b)
        {
            return (a < b);
        }
    }
}
