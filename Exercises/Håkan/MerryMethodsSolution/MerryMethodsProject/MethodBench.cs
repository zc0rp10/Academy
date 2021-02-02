using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethodsProject
{
    class MethodBench
    {

        public void FirstMethod()
        {
            Console.WriteLine("Marry Methods");
        }

        public void SecondMethod(string value)
        {
            Console.WriteLine(value);
        }

        public void ThirdMethod(string str, bool value)
        {
            string input;

            if (value == true)
                input = str.ToUpper();
            else
                input = str.ToLower();

            SecondMethod(input);
        }

        public bool FourthMethod()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            do
            {
                if (cki.Key == ConsoleKey.S)
                {
                    return true;
                }
                else if (cki.Key == ConsoleKey.W)
                {
                    return false;
                }
            } while (true);
        }

        public Tuple<string, bool> SixthMethod()
        {
            string Name = Console.ReadLine();
            bool LengthyName = (Name.Length > 5) ? true : false;

            var tuple = new Tuple<string, bool>(Name, LengthyName);
            
            return tuple;

            bool loggedIn = true;
            string msg = loggedIn ? "Log Out" : "Log In";
            Console.WriteLine(msg);
        }
    }
}
