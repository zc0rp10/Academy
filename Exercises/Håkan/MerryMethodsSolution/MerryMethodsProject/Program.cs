using System;

namespace MerryMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodBench = new MethodBench();

            // First
            int i = 1;
            do
            {
                methodBench.FirstMethod();
            } while (i++ < 3);

            // Second
            methodBench.SecondMethod("C# Now and Forever!");
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            methodBench.SecondMethod(userInput);

            // Third
            Console.Write("Print in uppercase (y/n)?: ");
            bool userBool = (Console.ReadLine().ToLower() == "y") ? true : false;
            methodBench.ThirdMethod(userInput, userBool);

            // Fourth
            Console.Write("[W]hisper or [S]hout?: ");
            bool shout = methodBench.FourthMethod();
            methodBench.ThirdMethod(userInput, shout);

            // Fifth(?)
            methodBench.ThirdMethod(userInput, methodBench.FourthMethod());

            // Sixth
            Console.Write("Enter a name: ");
            var myTuple = methodBench.SixthMethod();
            if (myTuple.Item2 == true)
                Console.WriteLine($"{myTuple.Item1} är ett långt namn.");
            else
                Console.WriteLine($"{myTuple.Item1} är inte ett långt namn.");
        }
    }
}
